using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace StudentManagemet
{
    public partial class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
       
        public int Age { get; set; }

        public string Gender { get; set; }

        public string LivigTown { get; set; }
        public string DataOfBirth { get; set; }

        public int Index { get; set; }
        public double GPA { get; set; }
        public BitmapImage Image { get; set; }
       

        public String Imagep
        {
            get { return $"/Image/{Image}"; }
        }

        public Student(int index, String firstName, String lastName, int age, string dateofbirth, double gpa, BitmapImage image, string gender, string livigtown)

        {   
            Index= index;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            DataOfBirth = dateofbirth;
            GPA = gpa;
            Image = image;
            Gender = gender;
            LivigTown = livigtown;
        }
        public Student()
        {

        }


    }
}
