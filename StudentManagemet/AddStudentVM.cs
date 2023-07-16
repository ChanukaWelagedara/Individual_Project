using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;

namespace StudentManagemet
{
    public partial class AddStudentVM : ObservableObject
    {
        [ObservableProperty]
        public string? firstname;

        [ObservableProperty]
        public string? lastname;

        [ObservableProperty]
        public int age;

        [ObservableProperty]
        public string? dateofbirth;

        [ObservableProperty]
        public double gpa;

        [ObservableProperty]
        public string? gender;

        public ObservableCollection<Student> students_;

        [ObservableProperty]
        public string? livigtown;
        [ObservableProperty]
        public BitmapImage? selectedImage;
        public AddStudentVM(ref ObservableCollection<Student> students) => students_ = students;
        [ObservableProperty]
        private string selectedGender;
        public Student? NStudent { get; private set; }
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
     


        [RelayCommand]
        public void UploadPhoto()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files | *.bmp; *.png; *.jpg";
            dialog.FilterIndex = 1;
            if (dialog.ShowDialog() == true)
            {
                SelectedImage = new BitmapImage(new Uri(dialog.FileName));
              
                MessageBox.Show("Imgae successfuly uploded!", "successfull");
            }
        }


        [RelayCommand]
        public void AddStudent()
        {
            const double MIN_GPA = 0;
            const double MAX_GPA = 4;

            if (gpa < MIN_GPA || gpa > MAX_GPA)
            {
                string errorMsg = $"GPA value must be between {MIN_GPA} and {MAX_GPA}.";
                MessageBox.Show(errorMsg, "Error");
                return;
            }

            if (string.IsNullOrWhiteSpace(Firstname) || string.IsNullOrWhiteSpace(Lastname) || string.IsNullOrWhiteSpace(Livigtown))
            {
                MessageBox.Show("Please enter the student's details correctly", "Error");
                return;
            }

            if (!IsMale && !IsFemale)
            {
                MessageBox.Show("Please select the student's gender", "Error");
                return;
            }
            if (dateofbirth == null)
            {
                MessageBox.Show("Please enter the student's date of birth", "Error");
                return;
            }
            if (age <= 0)
            {
                MessageBox.Show("Please enter the student's age", "Error");
                return;
            }
            if (selectedImage == null)
            {
                MessageBox.Show("Please upload the student's image", "Error");
                return;
            }

            if (IsMale)
            {
                gender = "Male";
            }
            else if (IsFemale)
            {
                gender = "Female";
            }

            NStudent = new Student
            {
                Index = ++MainwindowVM.index,
                FirstName = firstname,
                LastName = lastname,
                Age = age,
                DataOfBirth = dateofbirth,
                GPA = gpa,
                Image = selectedImage,
                Gender = gender,
                LivigTown = livigtown
            };

            students_.Add(NStudent);

            string successMsg = $"{NStudent.FirstName} {NStudent.LastName} is successfully added.";
            MessageBox.Show(successMsg, "Success");

            NStudent = null;

            var addStudentViewModel = new AddStudentVM(ref students_);
            var addStudentWindow = new AddStudent(addStudentViewModel);
            addStudentWindow.ShowDialog();
            /* UploadPhoto();*/
            CloseAction();
        }


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
