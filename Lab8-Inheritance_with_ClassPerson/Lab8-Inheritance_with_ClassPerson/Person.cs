using PersonLib;

namespace Lab8_Inheritance_with_ClassPerson
{
    public partial class Person : Form
    {
        // Using data binding
        private BindingSource bs = new BindingSource();
        // .. private BindingSource bs = new();
        public Person()
        {
            InitializeComponent();

            Program.PersonList.Added += (sender, per) => bs.ResetBindings(false);
            Program.PersonList.Modified += (sender, per) => bs.ResetBindings(false);
            Program.PersonList.Removed += (sender, per) => bs.ResetBindings(false);
            Program.PersonList.Cleared += (sender, per) => bs.ResetBindings(false);

            // Data Binding
            bs.DataSource = Program.PersonList;
            bs.DataMember = nameof(PersonList.People);
            // People from Empty list in Class PersonList that have in our PersonLib
            dgvPerson.DataSource = bs;
            ConfigGridView();

            // BTN event Handler
            btnRefresh.Click += (sender, e) => bs.ResetBindings(false);

            btnNew.Click += (sender, e) => new Creating().Show();
            btnEdit.Click += (sender, e) => {
                int no = (int?)dgvPerson.CurrentRow?.Cells[nameof(PersonLib.Person.No)].Value ?? -1;
                new Editting(no).Show();
            };

            btnDelete.Click += (sender, e) =>
            {
                int no = (int?)dgvPerson.CurrentRow.Cells[nameof(PersonLib.Person.No)].Value ?? -1;
                Program.PersonList.Remove(no);
            };
            btnDeleteAll.Click += (sender, e) => Program.PersonList.Clear();
        }

        private void ConfigGridView()
        {
            dgvPerson.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            foreach(DataGridViewColumn col in dgvPerson.Columns)
            {
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                if (col.Index == 0) continue;
                col.DefaultCellStyle.Format = "N2";
                // N2 : using to format with two decimal
            }
        }
    }
}
