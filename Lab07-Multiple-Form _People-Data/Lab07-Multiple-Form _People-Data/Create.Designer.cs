namespace Lab07_Multiple_Form__People_Data
{
    partial class Create
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
            label1 = new Label();
            txtNo = new TextBox();
            txtName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtAge = new TextBox();
            label4 = new Label();
            btnCreate = new Button();
            cbGender = new ComboBox();
            btnClear = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(44, 38);
            label1.Name = "label1";
            label1.Size = new Size(33, 23);
            label1.TabIndex = 0;
            label1.Text = "No";
            // 
            // txtNo
            // 
            txtNo.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtNo.Location = new Point(154, 35);
            txtNo.Name = "txtNo";
            txtNo.Size = new Size(189, 30);
            txtNo.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(154, 84);
            txtName.Name = "txtName";
            txtName.Size = new Size(189, 30);
            txtName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(44, 87);
            label2.Name = "label2";
            label2.Size = new Size(56, 23);
            label2.TabIndex = 2;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(44, 142);
            label3.Name = "label3";
            label3.Size = new Size(66, 23);
            label3.TabIndex = 4;
            label3.Text = "Gender";
            // 
            // txtAge
            // 
            txtAge.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtAge.Location = new Point(154, 199);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(112, 30);
            txtAge.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(44, 202);
            label4.Name = "label4";
            label4.Size = new Size(40, 23);
            label4.TabIndex = 6;
            label4.Text = "Age";
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.Lime;
            btnCreate.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnCreate.Location = new Point(192, 272);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(146, 43);
            btnCreate.TabIndex = 8;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = false;
            // 
            // cbGender
            // 
            cbGender.FormattingEnabled = true;
            cbGender.Location = new Point(154, 142);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(151, 28);
            cbGender.TabIndex = 9;
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.ActiveCaption;
            btnClear.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnClear.Location = new Point(39, 272);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(146, 43);
            btnClear.TabIndex = 10;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // Create
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(380, 347);
            Controls.Add(btnClear);
            Controls.Add(cbGender);
            Controls.Add(btnCreate);
            Controls.Add(txtAge);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(txtNo);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Create";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Create";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNo;
        private TextBox txtName;
        private Label label2;
        private Label label3;
        private TextBox txtAge;
        private Label label4;
        private Button btnCreate;
        private ComboBox cbGender;
        private Button btnClear;
    }
}