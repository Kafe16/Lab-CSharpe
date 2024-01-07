namespace Lab8_Inheritance_with_ClassPerson
{
    partial class Person
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
            dgvPerson = new DataGridView();
            btnRefresh = new Button();
            btnNew = new Button();
            btnEdit = new Button();
            btnDeleteAll = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPerson).BeginInit();
            SuspendLayout();
            // 
            // dgvPerson
            // 
            dgvPerson.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPerson.Location = new Point(65, 110);
            dgvPerson.Name = "dgvPerson";
            dgvPerson.RowHeadersWidth = 51;
            dgvPerson.Size = new Size(658, 352);
            dgvPerson.TabIndex = 0;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(65, 32);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(129, 46);
            btnRefresh.TabIndex = 1;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(804, 110);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(129, 46);
            btnNew.TabIndex = 2;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(804, 188);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(129, 46);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDeleteAll
            // 
            btnDeleteAll.Location = new Point(804, 420);
            btnDeleteAll.Name = "btnDeleteAll";
            btnDeleteAll.Size = new Size(129, 46);
            btnDeleteAll.TabIndex = 5;
            btnDeleteAll.Text = "Delete All";
            btnDeleteAll.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(804, 342);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(129, 46);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // Person
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(997, 520);
            Controls.Add(btnDeleteAll);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnNew);
            Controls.Add(btnRefresh);
            Controls.Add(dgvPerson);
            Name = "Person";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Person";
            ((System.ComponentModel.ISupportInitialize)dgvPerson).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvPerson;
        private Button btnRefresh;
        private Button btnNew;
        private Button btnEdit;
        private Button btnDeleteAll;
        private Button btnDelete;
    }
}
