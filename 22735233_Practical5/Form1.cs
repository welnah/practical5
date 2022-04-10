using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22735233_Practical5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Variables
        string name, surname, date;
        int age, price;
        

        private void radDocOne_CheckedChanged(object sender, EventArgs e)
        {

            name = Convert.ToString(txtFirstName.Text);
            surname = Convert.ToString(txtSurname.Text);
            age = Convert.ToInt32(nudAge.Value);
            date = Convert.ToString(dateTimePicker1.Text);


        }

        private void radDoCTwo_CheckedChanged(object sender, EventArgs e)
        {
            //input
            name = Convert.ToString(txtFirstName.Text);
            surname = Convert.ToString(txtSurname.Text);
            age = Convert.ToInt32(nudAge.Value);
            date = Convert.ToString(dateTimePicker1.Text);


        }


        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //output
            if (radDocOne.Checked)
            {



                if (age < 12)
                {
                    price = 100;
                }
                else if (age > 13 && age < 17)
                {
                    price = 120;
                }
                else if (age > 18 && age < 64)
                {
                    price = 150;
                }
                else if (age > 65)
                {
                    price = 110;
                }


            }

            //output
            if (radDoCTwo.Checked)
            {



                if (age < 12)
                {
                    price = 100;
                }
                else if (age > 13 && age < 17)
                {
                    price = 120;
                }
                else if (age > 18 && age < 64)
                {
                    price = 150;
                }
                else if (age > 65)
                {
                    price = 110;
                }


            }
            listBox1.Items.Add("Appointment is on: " + date + "\n");
            listBox1.Items.Add("Name:" + name + "\n");
            listBox1.Items.Add("Surname:" + surname + "\n");
            listBox1.Items.Add("Age:" + Convert.ToString(age));
            listBox1.Items.Add("\n" + "Price: R" + price);
        }
        
    }
}
