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
    public partial class Editting : Form
    {
        int _no = -1;
        public Editting(int no)
        {
            InitializeComponent();
            _no = no;
            cbGender.DataSource = new string[] {"","Male","Female","Other" };
            ViewEditPer();
            btnCancel.Click += (sender, e) => ViewEditPer();
            btnUpdate.Click += DoClickUpdate;

        }

    //  ----------------------------------------------------------------

        private void DoClickUpdate (object? sender, EventArgs e)
        {
            if(int.TryParse(txtNo.Text, out _no) == false)
            {
                MessageBox.Show($"Invalid no, {txtNo.Text}", "Updating", MessageBoxButtons.OK, MessageBoxIcon.Stop); 
                return;
            }

            var edit = Program.PersonList[_no]; // applying indexer
            if(edit == null ) 
            {
                MessageBox.Show($"No found a Person info with no, {_no}", "Updating", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            List<string> messages = new();
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

            if(Program.PersonList.Modify(_no, name, gender, age) != null)
            {
                MessageBox.Show($"A Person with no, {edit.No}, was successfully update", "Updating", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            this.Close();

        }

    //  --------------------------------------------------------------------
        private void ViewEditPer()
        {
            var edit = Program.PersonList[_no]; // Applying indexer
            txtNo.Text = edit?.No.ToString();
            txtName.Text = edit?.Name.ToString();
            cbGender.Text = edit?.Gender.ToString();
            txtAge.Text = edit?.Age.ToString();
        }
    }
}
