using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab07_Multiple_Form__People_Data
{
    public partial class EditForm : Form
    {
        public event PersonEventHandler? PersonChanged;
        Person? _edit = null; //need Person from somewhere far
        public EditForm(Person? edit)
        {
            InitializeComponent();
            _edit = edit;
            cbGender.DataSource = new string[] { "Male", "Female", "Other" };

            ViewPer();
            
            btnCancel.Click += (sender, e) => ViewPer();
            btnEdit.Click += DoClickUpdate;
        }

        // Write about btn Edit
        private void DoClickUpdate(object? sender, EventArgs e)
        {
            if(int.TryParse(txtNo.Text, out int no) ==  false )
            {
                MessageBox.Show("Invalid width", "Editing",
                       MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (byte.TryParse(txtAge.Text, out byte age) == false)
            {
                MessageBox.Show("Invalid Age", "Editing",
                        MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            string name = txtName.Text;

            string? gender = "";
            if (cbGender.SelectedIndex == 0)
            {
                gender = "Male";
            }
            else if (cbGender.SelectedIndex == 1)
            {
                gender = "Female";
            }
            else
            {
                gender = "Other";
            }

            // Checking if No. Match with data that we want to update
            _edit = Program.person.FirstOrDefault(x => x.No == no);
            if(_edit == null)
            {
                MessageBox.Show($"No found a person with number {no}", "Editing",
                        MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            _edit.Name = name;
            _edit.Gender = gender;
            _edit.Age = age;

            // After edit have to raise Event
            PersonChanged?.Invoke(this, _edit);
            this.Close();
        }

        private void ViewPer()
        {
            txtNo.Text = _edit?.No.ToString();
            txtName.Text = _edit?.Name.ToString();
            txtAge.Text = _edit?.Age.ToString();
        }
    }
}
