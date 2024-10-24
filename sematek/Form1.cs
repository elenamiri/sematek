using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sematek
{
    public partial class Form1 : Form
    {
        List<Models.Student> students = new List<Models.Student>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FirstNameTextBox1.Text) ||
                string.IsNullOrEmpty(LastNameTextBox2.Text) ||
                string.IsNullOrEmpty(PhoneNumberTextBox3.Text) ||
                string.IsNullOrEmpty(NationalCodeTextBox4.Text))
            {
                MessageBox.Show("please enter valid input");
                return;
            }

            string PhoneNumber = Utilities.CleanData.PhoneNumber(PhoneNumberTextBox3.Text);

          


            //object تعریف یک 
            //Student student = new Student();
            //student.FirstName = "elena";
            //student.LastName = "miri";
            //student.PhoneNumber = "09124971444";
            //student.NationalCode = "001269587";

            //object تعریف یک
            //Models.Student student = new Models.Student();
            //student.FirstName = "elena";
            //student.LastName = "miri";
            //student.PhoneNumber = "09124971444";
            //student.NationalCode = "001269587";


            //style 1
            //Models.Student student = new Models.Student();
            //student.FirstName = FirstNameTextBox1.Text;
            //student.LastName = LastNameTextBox2.Text;
            //student.PhoneNumber = PhoneNumberTextBox3.Text;
            //student.NationalCode = NationalCodeTextBox4.Text;

            //style 2
            //Models.Student student = new ();
            //student.FirstName = FirstNameTextBox1.Text;
            //student.LastName = LastNameTextBox2.Text;
            //student.PhoneNumber = PhoneNumberTextBox3.Text;
            //student.NationalCode = NationalCodeTextBox4.Text;

            //style 3
            //Models.Student student = new()
            //{
            //    FirstName = FirstNameTextBox1.Text,
            //    LastName = LastNameTextBox2.Text,
            //    PhoneNumber = PhoneNumberTextBox3.Text,
            //    NationalCode = NationalCodeTextBox4.Text
            //};

            Models.Student student = new(firstname: FirstNameTextBox1.Text, lastname: LastNameTextBox2.Text, nationalcode: NationalCodeTextBox4.Text, phonenumber: PhoneNumberTextBox3.Text);
            student.gender = enums.gender.male;
             students.Add(student);

            MessageBox.Show("Register SuccessFully");

            FirstNameTextBox1.Text = String.Empty;
            LastNameTextBox2.Text= String.Empty;
            PhoneNumberTextBox3.Text= String.Empty;
            NationalCodeTextBox4.Text= String.Empty;








            //string username = usernametextBox1.Text;
            //string pasword = PasswordtextBox2.Text;
            //if (username == "elena" && pasword == "12345")
            //{ MessageBox.Show("success"); }
            //else MessageBox.Show("unsuccess");

        }
    }
}
