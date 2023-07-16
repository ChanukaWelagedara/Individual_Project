using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace StudentManagemet
{
    /// <summary>
    /// Interaction logic for AddStudent.xaml
    /// </summary>
    public partial class AddStudent : Window
    {
        public AddStudent(AddStudentVM vm)
        {
            InitializeComponent();
            DataContext= vm;
            vm.CloseAction=()=>Close();
        }

       /* public AddStudent(ref ObservableCollection<Student> data)
        {
            DataContext = new AddStudentVM(ref data);
            InitializeComponent();
        }*/
       
    }
}

