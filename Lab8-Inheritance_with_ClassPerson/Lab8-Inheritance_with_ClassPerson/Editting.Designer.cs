namespace Lab8_Inheritance_with_ClassPerson
{
    partial class Editting
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
            btnUpdate = new Button();
            cbGender = new ComboBox();
            txtAge = new TextBox();
            txtName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            btnCancel = new Button();
            txtNo = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(382, 380);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(121, 46);
            btnUpdate.TabIndex = 17;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // cbGender
            // 
            cbGender.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbGender.FormattingEnabled = true;
            cbGender.Location = new Point(153, 254);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(189, 36);
            cbGender.TabIndex = 16;
            // 
            // txtAge
            // 
            txtAge.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAge.Location = new Point(153, 319);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(125, 34);
            txtAge.TabIndex = 15;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(153, 180);
            txtName.Name = "txtName";
            txtName.Size = new Size(350, 34);
            txtName.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(42, 257);
            label2.Name = "label2";
            label2.Size = new Size(85, 28);
            label2.TabIndex = 13;
            label2.Text = "Gender:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(42, 322);
            label3.Name = "label3";
            label3.Size = new Size(53, 28);
            label3.TabIndex = 12;
            label3.Text = "Age:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(42, 183);
            label1.Name = "label1";
            label1.Size = new Size(77, 28);
            label1.TabIndex = 11;
            label1.Text = "Name: ";
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(41, 34);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(121, 46);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // txtNo
            // 
            txtNo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNo.Location = new Point(153, 114);
            txtNo.Name = "txtNo";
            txtNo.Size = new Size(125, 34);
            txtNo.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(42, 117);
            label4.Name = "label4";
            label4.Size = new Size(44, 28);
            label4.TabIndex = 18;
            label4.Text = "No:";
            // 
            // Editting
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(534, 454);
            Controls.Add(txtNo);
            Controls.Add(label4);
            Controls.Add(btnUpdate);
            Controls.Add(cbGender);
            Controls.Add(txtAge);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Name = "Editting";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editting";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnUpdate;
        private ComboBox cbGender;
        private TextBox txtAge;
        private TextBox txtName;
        private Label label2;
        private Label label3;
        private Label label1;
        private Button btnCancel;
        private TextBox txtNo;
        private Label label4;
    }
}