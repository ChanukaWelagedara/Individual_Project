using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;

namespace StudentManagemet
{
    public partial class EditStudentVM : ObservableObject
    {

        [ObservableProperty]
        public string firstname;


        [ObservableProperty]
        public string lastname;

        [ObservableProperty]
        public int age;

        [ObservableProperty]
        public string dateofbirth;

        [ObservableProperty]
        public double gpa;
        [ObservableProperty]
        public BitmapImage isSelectedImage;
        [ObservableProperty]
        public string gender;
        [ObservableProperty]
        public string livingtown;

        [ObservableProperty]
        public Student selectedStudent;
        public Student NStudent { get; private set; }
        public Action CloseAction { get; internal set; }

        private bool isMale;
        public bool IsMale
        {
            get { return isMale; }
            set { SetProperty(ref isMale, value); }
        }

        private bool isFemale;
        public bool IsFemale
        {
            get { return isFemale; }
            set { SetProperty(ref isFemale, value); }
        }


        public EditStudentVM() { }

        public EditStudentVM(Student Stu)
        {
            NStudent = Stu;

            firstname = NStudent.FirstName;
            lastname = NStudent.LastName;
            age = NStudent.Age;
            gpa = NStudent.GPA;
            dateofbirth = NStudent.DataOfBirth;
            isSelectedImage = NStudent.Image;
            livingtown = NStudent.LivigTown;

            if (NStudent.Gender == "Male")
            {
                IsMale = true;
                IsFemale = false;
            }
            else if (NStudent.Gender == "Female")
            {
                IsMale = false;
                IsFemale = true;
            }

            gender = NStudent.Gender;
        }

      



        [RelayCommand]
        public void UploadPhoto()
        {
            OpenFileDialog newDialog = new OpenFileDialog();
            newDialog.Filter = "Image files | *.bmp; *.png; *.jpg";
            newDialog.FilterIndex = 1;
            if (newDialog.ShowDialog() == true)
            {
                IsSelectedImage = new BitmapImage(new Uri(newDialog.FileName));

                MessageBox.Show("Imgae successfuly uploded!", "successfull");
            }
        }

        [RelayCommand]
        public void EditStudent()
        {

            const double MIN_GPA = 0;
            const double MAX_GPA = 4;
            if (gpa < MIN_GPA || gpa > MAX_GPA)
            {
                string errorMsg = $"GPA value must be between {MIN_GPA} and {MAX_GPA}.";
                MessageBox.Show(errorMsg, "Error");
                return;
            }



            if (NStudent == null)
            {
                return;
                /* NStudent = new Student()
                 {
                     FirstName = firstname,
                     LastName = lastname,
                     Age = age,
                     DateOfBirth = dateofbirth,
                     GPA = gpa,
                     Image=SelectedImage

                 };*/
            }

            else
            {

                if (IsMale)
                {
                    gender = "Male";
                }
                else if (IsFemale)
                {
                    gender = "Female";
                }

                NStudent.FirstName = firstname;
                NStudent.LastName = lastname;
                NStudent.Age = age;
                NStudent.GPA = gpa;
                NStudent.DataOfBirth = dateofbirth;
                NStudent.Image = isSelectedImage;
                NStudent.Gender = gender;
                NStudent.LivigTown = livingtown;

            }
            if (NStudent.FirstName != null && NStudent.LastName != null)
            {
                string successMsg = $"{NStudent.FirstName} {NStudent.LastName} is successfully Edited.";
                MessageBox.Show(successMsg, "Success");
                CloseAction();
            }
            Application.Current.MainWindow.Show();


        }
        public RelayCommand CloseCommand => new RelayCommand(() =>
        {
            
            CloseAction?.Invoke();
        });

       
        [RelayCommand]
        public void Cancel()
        {
            CloseWindow();
        }

        private void CloseWindow()
        {
            foreach (Window window in Application.Current.Windows)
            {
                if (window.DataContext == this)
                {
                    window.DialogResult = true;
                    window.Close();

                }
            }
        }

    }
}

