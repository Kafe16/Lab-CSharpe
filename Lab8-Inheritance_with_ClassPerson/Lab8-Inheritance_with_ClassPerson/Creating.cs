using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8_Inheritance_with_ClassPerson
{
    public partial class Creating : Form
    {
        public Creating()
        {
            InitializeComponent();
            cbGender.DataSource = new string[] { "", "Male", "Female", "Other" };
            btnClear.Click += (sender, e) =>
            {
                txtName.Clear();
                txtAge.Clear();
            };

            btnCreate.Click += DoClickCreate;
            
        }

        private void DoClickCreate(object? sender, EventArgs e)
        {
            List<string> message = new();

            string? gender = "";
            if (cbGender.SelectedIndex == 1)
            {
                gender = "Male";
            }
            else if (cbGender.SelectedIndex == 2)
            {
                gender = "Female";
            }
            else if (cbGender.SelectedIndex == 3)
            {
                gender = "Other";
            }
            else
            {
                MessageBox.Show("Gender Require , Please select!", "Creating",
                        MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
        //  ----------------------------------------------------------

            if (byte.TryParse(txtAge.Text, out byte age) == false)
            {
                MessageBox.Show("Invalid Age", "Creating",
                        MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

        //  ----------------------------------------------------------

            string name = txtName.Text.Trim();
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Name Require", "Creating",
                        MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

        //  ----------------------------------------------------------

            PersonLib.Person per = new PersonLib.Person(name, gender, age);
            if(Program.PersonList.Add(per) == true)
            {
                MessageBox.Show($"New Person [ {name} | {gender} | {age} ] ,  was successfully created", "Creating" , MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            this.Close();
        }
    }
}
