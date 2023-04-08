namespace Loan_Calculator
{
    partial class ViewAllData
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
            textBox1 = new TextBox();
            monthlyIncome1 = new TextBox();
            label4 = new Label();
            cusName1 = new TextBox();
            cusId1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            eligibility1 = new TextBox();
            label1 = new Label();
            Instalment1 = new TextBox();
            label5 = new Label();
            interest1 = new TextBox();
            years1 = new TextBox();
            principal1 = new TextBox();
            years = new Label();
            intrestRate = new Label();
            principal = new Label();
            listBox1 = new ListBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            delete1 = new Button();
            edit1 = new Button();
            loanTypev = new Label();
            loantype2 = new TextBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(19, 31);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Search for Customers";
            textBox1.Size = new Size(395, 43);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // monthlyIncome1
            // 
            monthlyIncome1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            monthlyIncome1.Location = new Point(259, 235);
            monthlyIncome1.Margin = new Padding(3, 4, 3, 4);
            monthlyIncome1.Name = "monthlyIncome1";
            monthlyIncome1.ReadOnly = true;
            monthlyIncome1.Size = new Size(170, 39);
            monthlyIncome1.TabIndex = 39;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(22, 235);
            label4.Name = "label4";
            label4.Size = new Size(236, 41);
            label4.TabIndex = 38;
            label4.Text = "Monthly Income";
            // 
            // cusName1
            // 
            cusName1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            cusName1.Location = new Point(259, 169);
            cusName1.Margin = new Padding(3, 4, 3, 4);
            cusName1.Name = "cusName1";
            cusName1.ReadOnly = true;
            cusName1.Size = new Size(170, 39);
            cusName1.TabIndex = 37;
            // 
            // cusId1
            // 
            cusId1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            cusId1.Location = new Point(259, 103);
            cusId1.Margin = new Padding(3, 4, 3, 4);
            cusId1.Name = "cusId1";
            cusId1.ReadOnly = true;
            cusId1.Size = new Size(170, 39);
            cusId1.TabIndex = 36;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(22, 169);
            label3.Name = "label3";
            label3.Size = new Size(234, 41);
            label3.TabIndex = 35;
            label3.Text = "Customer Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(498, 365);
            label2.Name = "label2";
            label2.Size = new Size(136, 41);
            label2.TabIndex = 34;
            label2.Text = "Eligibility";
            label2.Click += label2_Click;
            // 
            // eligibility1
            // 
            eligibility1.BackColor = SystemColors.Control;
            eligibility1.BorderStyle = BorderStyle.None;
            eligibility1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            eligibility1.Location = new Point(760, 369);
            eligibility1.Margin = new Padding(3, 4, 3, 4);
            eligibility1.Name = "eligibility1";
            eligibility1.ReadOnly = true;
            eligibility1.Size = new Size(171, 36);
            eligibility1.TabIndex = 33;
            eligibility1.Visible = false;
            eligibility1.TextChanged += eligibility1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(19, 103);
            label1.Name = "label1";
            label1.Size = new Size(184, 41);
            label1.TabIndex = 32;
            label1.Text = "Customer ID";
            // 
            // Instalment1
            // 
            Instalment1.BackColor = SystemColors.Control;
            Instalment1.BorderStyle = BorderStyle.None;
            Instalment1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Instalment1.Location = new Point(801, 313);
            Instalment1.Margin = new Padding(3, 4, 3, 4);
            Instalment1.Name = "Instalment1";
            Instalment1.ReadOnly = true;
            Instalment1.Size = new Size(171, 32);
            Instalment1.TabIndex = 47;
            Instalment1.Visible = false;
            Instalment1.TextChanged += Instalment1_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(498, 305);
            label5.Name = "label5";
            label5.Size = new Size(276, 41);
            label5.TabIndex = 46;
            label5.Text = "Monthly Instalment";
            // 
            // interest1
            // 
            interest1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            interest1.Location = new Point(674, 173);
            interest1.Margin = new Padding(3, 4, 3, 4);
            interest1.Name = "interest1";
            interest1.ReadOnly = true;
            interest1.Size = new Size(171, 39);
            interest1.TabIndex = 45;
            // 
            // years1
            // 
            years1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            years1.Location = new Point(674, 239);
            years1.Margin = new Padding(3, 4, 3, 4);
            years1.Name = "years1";
            years1.ReadOnly = true;
            years1.Size = new Size(171, 39);
            years1.TabIndex = 44;
            years1.TextChanged += yearsv_TextChanged;
            // 
            // principal1
            // 
            principal1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            principal1.Location = new Point(674, 107);
            principal1.Margin = new Padding(3, 4, 3, 4);
            principal1.Name = "principal1";
            principal1.ReadOnly = true;
            principal1.Size = new Size(171, 39);
            principal1.TabIndex = 43;
            // 
            // years
            // 
            years.AutoSize = true;
            years.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            years.Location = new Point(498, 235);
            years.Name = "years";
            years.Size = new Size(86, 41);
            years.TabIndex = 42;
            years.Text = "Years";
            years.Click += years_Click;
            // 
            // intrestRate
            // 
            intrestRate.AutoSize = true;
            intrestRate.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            intrestRate.Location = new Point(498, 169);
            intrestRate.Name = "intrestRate";
            intrestRate.Size = new Size(185, 41);
            intrestRate.TabIndex = 41;
            intrestRate.Text = "Interest Rate";
            // 
            // principal
            // 
            principal.AutoSize = true;
            principal.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            principal.Location = new Point(498, 103);
            principal.Name = "principal";
            principal.Size = new Size(130, 41);
            principal.TabIndex = 40;
            principal.Text = "Principal";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(14, 477);
            listBox1.Margin = new Padding(3, 4, 3, 4);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(1099, 424);
            listBox1.TabIndex = 56;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(931, 435);
            label10.Name = "label10";
            label10.Size = new Size(151, 32);
            label10.TabIndex = 55;
            label10.Text = "New Balance";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(755, 435);
            label9.Name = "label9";
            label9.Size = new Size(152, 32);
            label9.TabIndex = 54;
            label9.Text = "Total Interest";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(603, 435);
            label8.Name = "label8";
            label8.Size = new Size(145, 32);
            label8.TabIndex = 53;
            label8.Text = "Interest Paid";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(446, 435);
            label7.Name = "label7";
            label7.Size = new Size(155, 32);
            label7.TabIndex = 52;
            label7.Text = "Principal Paid";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(275, 435);
            label6.Name = "label6";
            label6.Size = new Size(165, 32);
            label6.TabIndex = 51;
            label6.Text = "Monthly Pymt";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(124, 435);
            label11.Name = "label11";
            label11.Size = new Size(135, 32);
            label11.TabIndex = 50;
            label11.Text = "Starting Bal";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(25, 435);
            label12.Name = "label12";
            label12.Size = new Size(86, 32);
            label12.TabIndex = 49;
            label12.Text = "Month";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(11, 371);
            label13.Name = "label13";
            label13.Size = new Size(266, 41);
            label13.TabIndex = 48;
            label13.Text = "Amortization Table";
            // 
            // delete1
            // 
            delete1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            delete1.Location = new Point(888, 31);
            delete1.Margin = new Padding(3, 4, 3, 4);
            delete1.Name = "delete1";
            delete1.Size = new Size(95, 51);
            delete1.TabIndex = 57;
            delete1.Text = "Delete";
            delete1.UseVisualStyleBackColor = true;
            delete1.Click += delete1_Click;
            // 
            // edit1
            // 
            edit1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            edit1.Location = new Point(760, 31);
            edit1.Margin = new Padding(3, 4, 3, 4);
            edit1.Name = "edit1";
            edit1.Size = new Size(95, 51);
            edit1.TabIndex = 58;
            edit1.Text = "Edit";
            edit1.UseVisualStyleBackColor = true;
            edit1.Click += edit1_Click;
            // 
            // loanTypev
            // 
            loanTypev.AutoSize = true;
            loanTypev.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            loanTypev.Location = new Point(22, 305);
            loanTypev.Name = "loanTypev";
            loanTypev.Size = new Size(188, 41);
            loanTypev.TabIndex = 87;
            loanTypev.Text = "Type of Loan";
            // 
            // loantype2
            // 
            loantype2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            loantype2.Location = new Point(259, 309);
            loantype2.Margin = new Padding(3, 4, 3, 4);
            loantype2.Name = "loantype2";
            loantype2.ReadOnly = true;
            loantype2.Size = new Size(170, 39);
            loantype2.TabIndex = 88;
            // 
            // ViewAllData
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1167, 917);
            Controls.Add(loantype2);
            Controls.Add(loanTypev);
            Controls.Add(edit1);
            Controls.Add(delete1);
            Controls.Add(listBox1);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(label13);
            Controls.Add(Instalment1);
            Controls.Add(label5);
            Controls.Add(interest1);
            Controls.Add(years1);
            Controls.Add(principal1);
            Controls.Add(years);
            Controls.Add(intrestRate);
            Controls.Add(principal);
            Controls.Add(monthlyIncome1);
            Controls.Add(label4);
            Controls.Add(cusName1);
            Controls.Add(cusId1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(eligibility1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ViewAllData";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "View Details";
            FormClosing += ViewAllData_FormClosing;
            Load += ViewAllData_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox monthlyIncome1;
        private Label label4;
        private TextBox cusName1;
        private TextBox cusId1;
        private Label label3;
        private Label label2;
        private TextBox eligibility1;
        private Label label1;
        private TextBox Instalment1;
        private Label label5;
        private TextBox interest1;
        private TextBox years1;
        private TextBox principal1;
        private Label years;
        private Label intrestRate;
        private Label principal;
        private ListBox listBox1;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label11;
        private Label label12;
        private Label label13;
        private Button delete1;
        private Button edit1;
        private Label loanTypev;
        private TextBox loantype2;
    }
}