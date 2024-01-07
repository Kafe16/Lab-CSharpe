namespace Lab8_Inheritance_with_ClassPerson
{
    partial class Creating
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
            btnClear = new Button();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtName = new TextBox();
            txtAge = new TextBox();
            cbGender = new ComboBox();
            btnCreate = new Button();
            SuspendLayout();
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(59, 52);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(121, 46);
            btnClear.TabIndex = 0;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(59, 150);
            label1.Name = "label1";
            label1.Size = new Size(77, 28);
            label1.TabIndex = 1;
            label1.Text = "Name: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(59, 289);
            label3.Name = "label3";
            label3.Size = new Size(53, 28);
            label3.TabIndex = 3;
            label3.Text = "Age:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(59, 224);
            label2.Name = "label2";
            label2.Size = new Size(85, 28);
            label2.TabIndex = 4;
            label2.Text = "Gender:";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(170, 147);
            txtName.Name = "txtName";
            txtName.Size = new Size(350, 34);
            txtName.TabIndex = 5;
            // 
            // txtAge
            // 
            txtAge.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAge.Location = new Point(170, 286);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(125, 34);
            txtAge.TabIndex = 6;
            // 
            // cbGender
            // 
            cbGender.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbGender.FormattingEnabled = true;
            cbGender.Location = new Point(170, 221);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(189, 36);
            cbGender.TabIndex = 7;
            // 
            // btnCreate
            // 
            btnCreate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreate.Location = new Point(399, 368);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(121, 46);
            btnCreate.TabIndex = 9;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            // 
            // Creating
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(584, 450);
            Controls.Add(btnCreate);
            Controls.Add(cbGender);
            Controls.Add(txtAge);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(btnClear);
            Name = "Creating";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Creating";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClear;
        private Label label1;
        private Label label3;
        private Label label2;
        private TextBox txtName;
        private TextBox txtAge;
        private ComboBox cbGender;
        private Button btnCreate;
    }
}