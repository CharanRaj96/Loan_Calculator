namespace Loan_Calculator
{
    partial class EditCustomerForm
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
            listBox1 = new ListBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            Instalment1 = new TextBox();
            label5 = new Label();
            interest1 = new TextBox();
            years1 = new TextBox();
            principal1 = new TextBox();
            years = new Label();
            intrestRate = new Label();
            principal = new Label();
            monthlyIncome1 = new TextBox();
            label4 = new Label();
            cusName1 = new TextBox();
            cusId1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            eligibility1 = new TextBox();
            label1 = new Label();
            save1 = new Button();
            calculate1 = new Button();
            loanTypev = new Label();
            comboBox2 = new ComboBox();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 296);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(914, 319);
            listBox1.TabIndex = 81;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(765, 264);
            label10.Name = "label10";
            label10.Size = new Size(121, 25);
            label10.TabIndex = 80;
            label10.Text = "New Balance";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(636, 264);
            label9.Name = "label9";
            label9.Size = new Size(120, 25);
            label9.TabIndex = 79;
            label9.Text = "Total Interest";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(510, 264);
            label8.Name = "label8";
            label8.Size = new Size(116, 25);
            label8.TabIndex = 78;
            label8.Text = "Interest Paid";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(370, 264);
            label7.Name = "label7";
            label7.Size = new Size(127, 25);
            label7.TabIndex = 77;
            label7.Text = "Principal Paid";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(228, 264);
            label6.Name = "label6";
            label6.Size = new Size(129, 25);
            label6.TabIndex = 76;
            label6.Text = "Monthly Pymt";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(105, 264);
            label11.Name = "label11";
            label11.Size = new Size(108, 25);
            label11.TabIndex = 75;
            label11.Text = "Starting Bal";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(12, 264);
            label12.Name = "label12";
            label12.Size = new Size(68, 25);
            label12.TabIndex = 74;
            label12.Text = "Month";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(10, 216);
            label13.Name = "label13";
            label13.Size = new Size(213, 32);
            label13.TabIndex = 73;
            label13.Text = "Amortization Table";
            // 
            // Instalment1
            // 
            Instalment1.BackColor = SystemColors.Control;
            Instalment1.BorderStyle = BorderStyle.None;
            Instalment1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Instalment1.Location = new Point(689, 168);
            Instalment1.Name = "Instalment1";
            Instalment1.ReadOnly = true;
            Instalment1.Size = new Size(150, 25);
            Instalment1.TabIndex = 72;
            Instalment1.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(436, 162);
            label5.Name = "label5";
            label5.Size = new Size(223, 32);
            label5.TabIndex = 71;
            label5.Text = "Monthly Instalment";
            // 
            // interest1
            // 
            interest1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            interest1.Location = new Point(615, 68);
            interest1.Name = "interest1";
            interest1.Size = new Size(152, 32);
            interest1.TabIndex = 70;
            interest1.KeyPress += interest1_KeyPress;
            // 
            // years1
            // 
            years1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            years1.Location = new Point(615, 117);
            years1.Name = "years1";
            years1.Size = new Size(152, 32);
            years1.TabIndex = 69;
            years1.KeyPress += years1_KeyPress;
            // 
            // principal1
            // 
            principal1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            principal1.Location = new Point(615, 18);
            principal1.Name = "principal1";
            principal1.Size = new Size(152, 32);
            principal1.TabIndex = 68;
            principal1.KeyPress += principal1_KeyPress;
            // 
            // years
            // 
            years.AutoSize = true;
            years.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            years.Location = new Point(436, 114);
            years.Name = "years";
            years.Size = new Size(68, 32);
            years.TabIndex = 67;
            years.Text = "Years";
            // 
            // intrestRate
            // 
            intrestRate.AutoSize = true;
            intrestRate.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            intrestRate.Location = new Point(436, 65);
            intrestRate.Name = "intrestRate";
            intrestRate.Size = new Size(148, 32);
            intrestRate.TabIndex = 66;
            intrestRate.Text = "Interest Rate";
            // 
            // principal
            // 
            principal.AutoSize = true;
            principal.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            principal.Location = new Point(436, 15);
            principal.Name = "principal";
            principal.Size = new Size(104, 32);
            principal.TabIndex = 65;
            principal.Text = "Principal";
            // 
            // monthlyIncome1
            // 
            monthlyIncome1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            monthlyIncome1.Location = new Point(228, 114);
            monthlyIncome1.Name = "monthlyIncome1";
            monthlyIncome1.Size = new Size(175, 32);
            monthlyIncome1.TabIndex = 64;
            monthlyIncome1.KeyPress += monthlyIncome1_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(19, 114);
            label4.Name = "label4";
            label4.Size = new Size(190, 32);
            label4.TabIndex = 63;
            label4.Text = "Monthly Income";
            // 
            // cusName1
            // 
            cusName1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            cusName1.Location = new Point(228, 65);
            cusName1.Name = "cusName1";
            cusName1.Size = new Size(175, 32);
            cusName1.TabIndex = 62;
            // 
            // cusId1
            // 
            cusId1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            cusId1.Location = new Point(228, 15);
            cusId1.Name = "cusId1";
            cusId1.ReadOnly = true;
            cusId1.Size = new Size(175, 32);
            cusId1.TabIndex = 61;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(19, 65);
            label3.Name = "label3";
            label3.Size = new Size(188, 32);
            label3.TabIndex = 60;
            label3.Text = "Customer Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(436, 206);
            label2.Name = "label2";
            label2.Size = new Size(110, 32);
            label2.TabIndex = 59;
            label2.Text = "Eligibility";
            // 
            // eligibility1
            // 
            eligibility1.BackColor = SystemColors.Control;
            eligibility1.BorderStyle = BorderStyle.None;
            eligibility1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            eligibility1.Location = new Point(668, 208);
            eligibility1.Name = "eligibility1";
            eligibility1.ReadOnly = true;
            eligibility1.Size = new Size(150, 29);
            eligibility1.TabIndex = 58;
            eligibility1.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(17, 15);
            label1.Name = "label1";
            label1.Size = new Size(147, 32);
            label1.TabIndex = 57;
            label1.Text = "Customer ID";
            // 
            // save1
            // 
            save1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            save1.Location = new Point(821, 117);
            save1.Name = "save1";
            save1.Size = new Size(105, 38);
            save1.TabIndex = 82;
            save1.Text = "Update";
            save1.UseVisualStyleBackColor = true;
            save1.Click += save1_Click;
            // 
            // calculate1
            // 
            calculate1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            calculate1.Location = new Point(821, 62);
            calculate1.Name = "calculate1";
            calculate1.Size = new Size(105, 38);
            calculate1.TabIndex = 83;
            calculate1.Text = "Calculate";
            calculate1.UseVisualStyleBackColor = true;
            calculate1.Click += calculate1_Click;
            // 
            // loanTypev
            // 
            loanTypev.AutoSize = true;
            loanTypev.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            loanTypev.Location = new Point(19, 158);
            loanTypev.Name = "loanTypev";
            loanTypev.Size = new Size(152, 32);
            loanTypev.TabIndex = 85;
            loanTypev.Text = "Type of Loan";
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Car Loan", "Personal Loan", "Housing Loan" });
            comboBox2.Location = new Point(228, 161);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(175, 33);
            comboBox2.TabIndex = 84;
            // 
            // EditCustomerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(945, 629);
            Controls.Add(loanTypev);
            Controls.Add(comboBox2);
            Controls.Add(calculate1);
            Controls.Add(save1);
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
            Name = "EditCustomerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditCustomerForm";
            FormClosing += EditCustomerForm_FormClosing;
            Load += EditCustomerForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label11;
        private Label label12;
        private Label label13;
        private TextBox Instalment1;
        private Label label5;
        private TextBox interest1;
        private TextBox years1;
        private TextBox principal1;
        private Label years;
        private Label intrestRate;
        private Label principal;
        private TextBox monthlyIncome1;
        private Label label4;
        private TextBox cusName1;
        private TextBox cusId1;
        private Label label3;
        private Label label2;
        private TextBox eligibility1;
        private Label label1;
        private Button save1;
        private Button calculate1;
        private Label loanTypev;
        private ComboBox comboBox2;
    }
}