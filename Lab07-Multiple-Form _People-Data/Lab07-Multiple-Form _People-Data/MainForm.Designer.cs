namespace Lab07_Multiple_Form__People_Data
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnRefresh = new Button();
            dgvPerson = new DataGridView();
            No = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            btnNew = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPerson).BeginInit();
            SuspendLayout();
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.DeepSkyBlue;
            btnRefresh.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnRefresh.ForeColor = SystemColors.Control;
            btnRefresh.Location = new Point(41, 37);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(94, 57);
            btnRefresh.TabIndex = 0;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // dgvPerson
            // 
            dgvPerson.AllowUserToAddRows = false;
            dgvPerson.AllowUserToDeleteRows = false;
            dgvPerson.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPerson.Columns.AddRange(new DataGridViewColumn[] { No, Column1, Column2, Column3 });
            dgvPerson.Location = new Point(24, 136);
            dgvPerson.Name = "dgvPerson";
            dgvPerson.ReadOnly = true;
            dgvPerson.RowHeadersWidth = 51;
            dgvPerson.RowTemplate.Height = 29;
            dgvPerson.Size = new Size(555, 240);
            dgvPerson.TabIndex = 1;
            // 
            // No
            // 
            No.HeaderText = "No";
            No.MinimumWidth = 6;
            No.Name = "No";
            No.ReadOnly = true;
            No.Width = 125;
            // 
            // Column1
            // 
            Column1.HeaderText = "Name";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Gender";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Age";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 125;
            // 
            // btnNew
            // 
            btnNew.BackColor = SystemColors.ActiveCaption;
            btnNew.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnNew.Location = new Point(24, 399);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(120, 47);
            btnNew.TabIndex = 2;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.LimeGreen;
            btnEdit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEdit.Location = new Point(242, 399);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(120, 47);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = SystemColors.ButtonHighlight;
            btnDelete.Location = new Point(459, 399);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(120, 47);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BlanchedAlmond;
            ClientSize = new Size(600, 519);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnNew);
            Controls.Add(dgvPerson);
            Controls.Add(btnRefresh);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)dgvPerson).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnRefresh;
        private DataGridView dgvPerson;
        private Button btnNew;
        private Button btnEdit;
        private Button btnDelete;
        private DataGridViewTextBoxColumn No;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
    }
}
