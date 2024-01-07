namespace Lab07_Multiple_Form__People_Data
{
    partial class EditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCancel = new Button();
            cbGender = new ComboBox();
            btnEdit = new Button();
            txtAge = new TextBox();
            label4 = new Label();
            label3 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            txtNo = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.ActiveCaption;
            btnCancel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.Location = new Point(31, 273);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(146, 43);
            btnCancel.TabIndex = 20;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // cbGender
            // 
            cbGender.FormattingEnabled = true;
            cbGender.Location = new Point(146, 143);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(151, 28);
            cbGender.TabIndex = 19;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.Lime;
            btnEdit.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnEdit.Location = new Point(184, 273);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(146, 43);
            btnEdit.TabIndex = 18;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // txtAge
            // 
            txtAge.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtAge.Location = new Point(146, 200);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(112, 30);
            txtAge.TabIndex = 17;
            txtAge.TextAlign = HorizontalAlignment.Right;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(36, 203);
            label4.Name = "label4";
            label4.Size = new Size(40, 23);
            label4.TabIndex = 16;
            label4.Text = "Age";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(36, 143);
            label3.Name = "label3";
            label3.Size = new Size(66, 23);
            label3.TabIndex = 15;
            label3.Text = "Gender";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(146, 85);
            txtName.Name = "txtName";
            txtName.Size = new Size(189, 30);
            txtName.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(36, 88);
            label2.Name = "label2";
            label2.Size = new Size(56, 23);
            label2.TabIndex = 13;
            label2.Text = "Name";
            // 
            // txtNo
            // 
            txtNo.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtNo.Location = new Point(146, 36);
            txtNo.Name = "txtNo";
            txtNo.Size = new Size(189, 30);
            txtNo.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(36, 39);
            label1.Name = "label1";
            label1.Size = new Size(33, 23);
            label1.TabIndex = 11;
            label1.Text = "No";
            // 
            // EditForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(367, 370);
            Controls.Add(btnCancel);
            Controls.Add(cbGender);
            Controls.Add(btnEdit);
            Controls.Add(txtAge);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(txtNo);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EditForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private ComboBox cbGender;
        private Button btnEdit;
        private TextBox txtAge;
        private Label label4;
        private Label label3;
        private TextBox txtName;
        private Label label2;
        private TextBox txtNo;
        private Label label1;
    }
}