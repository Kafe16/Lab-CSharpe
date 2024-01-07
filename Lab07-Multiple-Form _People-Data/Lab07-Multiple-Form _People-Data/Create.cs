using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab07_Multiple_Form__People_Data
{
    public delegate void PersonEventHandler(object? sender, Person per);
    public partial class Create : Form
    {
        // Create event that show that obj has created -> Refer to DoClickCreated
        public event PersonEventHandler? PersonCreated;
        public Create()
        {
            InitializeComponent();
            btnClear.Click += (sender, e) =>
            {
                txtNo.Clear();
                txtName.Clear();
                txtAge.Clear();
                txtNo.Focus();
            };

            btnCreate.Click += DoClickCreate;

            cbGender.DataSource = new string[] {"","Male", "Female", "Other" };
        }

        private void DoClickCreate(object? sender, EventArgs e)
        {
            /*
            string name = "Hak Arun"
            string gender = "Male";
            byte age = 23;*/
            string? gender = "";

            if(byte.TryParse(txtAge.Text, out byte age) == false)
            {
                MessageBox.Show("Invalid Age", "Creating" , 
                        MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if(cbGender.SelectedIndex == 1)
            {
                gender = "Male";
            }else if(cbGender.SelectedIndex == 2)
            {
                gender = "Female";
            }
            else if(cbGender.SelectedIndex == 3)
            {
                gender = "Other";
            }

            string name = txtName.Text.Trim();
            if(string.IsNullOrEmpty(name)) 
            {
                MessageBox.Show("Name Require", "Creating",
                        MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            


            Person per = new Person(name, gender, age);
            Program.person.Add(per);
            PersonCreated?.Invoke(this, per); // Raise Event
            this.Close();
        }
    }
}
