
namespace Lab07_Multiple_Form__People_Data
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            btnRefresh.Click += DoClickRefresh;
            btnDelete.Click += DoClickDelete;
            btnNew.Click += (sender, e) =>
            {
                Create frm = new Create();
                frm.PersonCreated += (sender, per) =>
                {
                    dgvPerson.Rows.Add(per.No, per.Name, per.Gender, per.Age);
                };
                frm.Show();

            };
            btnEdit.Click += DoClickEdit;
            ConfigView();

        }

        private void DoClickEdit(object? sender, EventArgs e)
        {
            Person? per = null;
            if(dgvPerson.CurrentRow != null) 
            {
                int no = (int)dgvPerson.CurrentRow.Cells[0].Value;
                per = Program.person.FirstOrDefault(x => x.No == no);
            }
            EditForm frm = new EditForm(per);
            frm.PersonChanged += (sender, e) =>
            {
                foreach (DataGridViewRow row in dgvPerson.Rows)
                {
                    if (per.No == (int)row.Cells[0].Value)
                    {
                        row.SetValues(per.No, per.Name, per.Gender, per.Age);
                        break;
                    }
                }
            };
            frm.Show();
        }

        private void ConfigView()
        {
            foreach(DataGridViewColumn col in dgvPerson.Columns)
            {
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
        }

        private void DoClickRefresh(object? sender, EventArgs e)
        {
            dgvPerson.Rows.Clear();
            foreach (Person per in Program.person)
            {
                dgvPerson.Rows.Add(per.No, per.Name, per.Gender, per.Age);
            }
        }

        private void DoClickDelete(object? sender, EventArgs e)
        {
            if (dgvPerson.CurrentRow == null) return;
            int no = (int)dgvPerson.CurrentRow.Cells[0].Value;
            Person? found = Program.person.FirstOrDefault(x => x.No == no);

            if (found == null) return;
            var result = MessageBox.Show($"Are you sure about deleting this row number | {no} |?", "Deleting", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.No) return;
            if(Program.person.Remove(found)== true )
            {
                dgvPerson.Rows.Remove(dgvPerson.CurrentRow);
            }
        }
    }
}
