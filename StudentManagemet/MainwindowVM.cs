using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace StudentManagemet
{
    public partial class MainwindowVM : ObservableObject
    {
        
        [ObservableProperty]
        public Student selectedStudent ;
        private ObservableCollection<Student> originalStudentsList;
        private ObservableCollection<Student> _students;

        public static int index = 1003;


        public ObservableCollection<Student> Students
        {
            get { return _students; }
            set
            {
                if (_students != value)
                {
                    _students = value;
                    OnPropertyChanged(nameof(Students));
                }
            }
        }

       

        private string _searchText;
        public string SearchText
        {
            get { return _searchText; }
            set
            {
                if (_searchText != value)
                {
                    _searchText = value;
                    OnPropertyChanged(nameof(SearchText));
                }
            }
        }
        private int _totalCount;
        public int TotalCount
        {
            get { return _totalCount; }
            set
            {
                if (_totalCount != value)
                {
                    _totalCount = value;
                    OnPropertyChanged(nameof(TotalCount));
                }
            }
        }
       private int _maleStudentCount;
        public int MaleStudentCount
        {
            get { return _maleStudentCount; }
            set
            {
                if (_maleStudentCount != value)
                {
                    _maleStudentCount = value;
                    OnPropertyChanged(nameof(MaleStudentCount));
                }
            }
        }

        private int _femaleStudentCount;
        public int FemaleStudentCount
        {
            get { return _femaleStudentCount; }
            set
            {
                if (_femaleStudentCount != value)
                {
                    _femaleStudentCount = value;
                    OnPropertyChanged(nameof(FemaleStudentCount));
                }
            }
        }


        [RelayCommand]
        public void GetCount()
        {
            TotalCount = Students.Count;

           int maleCount = Students.Count(s => s.Gender.Equals("male", StringComparison.OrdinalIgnoreCase));
            int femaleCount = Students.Count(s => s.Gender.Equals("female", StringComparison.OrdinalIgnoreCase));

            MaleStudentCount = maleCount;
            FemaleStudentCount = femaleCount;
        }


        [RelayCommand]
        public void Search()
        {
            string searchText = SearchText;
            
            if (string.IsNullOrWhiteSpace(searchText))
            {
                
                Students = new ObservableCollection<Student>(Students.OrderBy(s => s.FirstName));
                return;
            }



            originalStudentsList = Students;

           
            var filteredStudents = Students.Where(
                s =>
                s.FirstName.ToLower().Contains(searchText.ToLower())
                ||
                s.LastName.ToLower().Contains(searchText.ToLower()));


            Students = new ObservableCollection<Student>(filteredStudents.OrderBy(s => s.FirstName));




        }

       /* public MainwindowVM(Student selectedStudent)
        {
            this.selectedStudent = selectedStudent;
        }*/

        [RelayCommand]
        public void messeag1()
        {
            MessageBox.Show("SucessFully Added");
        }

        [RelayCommand]
        public void DeleteStudent()
        {
            if (selectedStudent != null)
            {
                string message = $"Are you sure you want to delete {selectedStudent.FirstName} {selectedStudent.LastName}?";
                MessageBoxResult result = MessageBox.Show(message, "Confirm Deletion", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                if (result == MessageBoxResult.Yes)
                {
                    Students.Remove(selectedStudent);
                    GetCount();
                }
            }
            else
            {
                MessageBox.Show("Please select a student.");
            }
        }

        [RelayCommand]
        public void AddStudent()
        {

            var addStudentViewModel = new AddStudentVM(ref _students);
            var addStudentWindow = new AddStudent(addStudentViewModel);
            addStudentWindow.ShowDialog();
            GetCount();

        }

        


        [RelayCommand]
        public void EditStudent()
        {
            if (selectedStudent != null)
            {
                var vm = new EditStudentVM(SelectedStudent);
                var window = new EditStudent(vm);
                window.ShowDialog();

                int index = Students.IndexOf(SelectedStudent);
                Students.RemoveAt(index);
                Students.Insert(index, vm.NStudent);
                originalStudentsList = Students;
            }
            else
            {
                MessageBox.Show("Please Select the student", "Warning!");
            }

            GetCount();

        }


        [RelayCommand]
        public void Reset()
        {
            SearchText = "";
            Students = originalStudentsList;
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
                     
                      window.Close();

                  }
              }
          }

        [RelayCommand]
        public void minimize()
        {
            minimizeWindow();
        }
        private void minimizeWindow()
        {
            foreach (Window window in Application.Current.Windows)
            {
                if (window.DataContext == this)
                {
                    window.WindowState = WindowState.Minimized;
                }
            }
        }
      

        private bool _isMaximized;

        public bool IsMaximized
        {
            get { return _isMaximized; }
            set
            {
                _isMaximized = value;
                OnPropertyChanged(nameof(IsMaximized));
            }
        }

        [RelayCommand]
        public void Maximize()
        {
            if (IsMaximized)
            {
                RestoreWindow();
            }
            else
            {
                MaximizeWindow();
            }
        }

        private void MaximizeWindow()
        {
            foreach (Window window in Application.Current.Windows)
            {
                if (window.DataContext is MainwindowVM viewModel && window is MainWindow mainWindow)
                {
                    mainWindow.WindowState = WindowState.Maximized;
                    viewModel.IsMaximized = true;
                }
            }
        }

        private void RestoreWindow()
        {
            foreach (Window window in Application.Current.Windows)
            {
                if (window.DataContext is MainwindowVM viewModel && window is MainWindow mainWindow)
                {
                    mainWindow.WindowState = WindowState.Normal;
                    viewModel.IsMaximized = false;
                }
            }
        }




        public MainwindowVM()
        {
            Students = new ObservableCollection<Student>();
             BitmapImage image1 = new BitmapImage(new Uri("Image/2.png", UriKind.Relative));
             Students.Add(new Student(1000, "Chamika", "Dias", 24, "1999/1/1",2,image1,"Male","Kandy"));
             BitmapImage image2 = new BitmapImage(new Uri("Image/3.png", UriKind.Relative));
             Students.Add(new Student(1001, "Denuwa", "Perea", 20, "1999/1/1", 2 ,image2,"Male", "Kandy"));
             BitmapImage image3 = new BitmapImage(new Uri("Image/4.png", UriKind.Relative));
             Students.Add(new Student(1002,"Dinesh", "Karthik", 27, "1999/1/1", 2,image3, "Male", "Kandy"));
             BitmapImage image4 = new BitmapImage(new Uri("Image/5.png", UriKind.Relative));
             Students.Add(new Student(1003,"Malith", "Isuru", 24, "1999/1/1", 2,image4, "Male", "Kandy"));
            originalStudentsList = new();
            originalStudentsList = Students;
            GetCount();

            //SelectedStudent = Students.FirstOrDefault();


        }

    }
}
