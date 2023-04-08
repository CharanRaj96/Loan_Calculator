namespace Loan_Calculator
{
    partial class Form1
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
            principal = new Label();
            intrestRate = new Label();
            years = new Label();
            principalv = new TextBox();
            yearsv = new TextBox();
            interestv = new TextBox();
            label1 = new Label();
            Instalmentv = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // principal
            // 
            principal.AutoSize = true;
            principal.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            principal.Location = new Point(12, 16);
            principal.Name = "principal";
            principal.Size = new Size(104, 32);
            principal.TabIndex = 0;
            principal.Text = "Principal";
            principal.Click += label1_Click;
            // 
            // intrestRate
            // 
            intrestRate.AutoSize = true;
            intrestRate.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            intrestRate.Location = new Point(12, 57);
            intrestRate.Name = "intrestRate";
            intrestRate.Size = new Size(148, 32);
            intrestRate.TabIndex = 1;
            intrestRate.Text = "Interest Rate";
            // 
            // years
            // 
            years.AutoSize = true;
            years.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            years.Location = new Point(12, 98);
            years.Name = "years";
            years.Size = new Size(68, 32);
            years.TabIndex = 2;
            years.Text = "Years";
            years.Click += label1_Click_1;
            // 
            // principalv
            // 
            principalv.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            principalv.Location = new Point(203, 19);
            principalv.Name = "principalv";
            principalv.Size = new Size(150, 32);
            principalv.TabIndex = 3;
            principalv.KeyPress += principalv_KeyPress;
            // 
            // yearsv
            // 
            yearsv.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            yearsv.Location = new Point(199, 101);
            yearsv.Name = "yearsv";
            yearsv.Size = new Size(150, 32);
            yearsv.TabIndex = 4;
            yearsv.TextChanged += yearsv_TextChanged;
            yearsv.KeyPress += yearsv_KeyPress;
            // 
            // interestv
            // 
            interestv.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            interestv.Location = new Point(201, 60);
            interestv.Name = "interestv";
            interestv.Size = new Size(150, 32);
            interestv.TabIndex = 5;
            interestv.KeyPress += interestv_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 161);
            label1.Name = "label1";
            label1.Size = new Size(223, 32);
            label1.TabIndex = 6;
            label1.Text = "Monthly Instalment";
            // 
            // Instalmentv
            // 
            Instalmentv.BackColor = SystemColors.Control;
            Instalmentv.BorderStyle = BorderStyle.None;
            Instalmentv.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Instalmentv.Location = new Point(263, 167);
            Instalmentv.Name = "Instalmentv";
            Instalmentv.ReadOnly = true;
            Instalmentv.Size = new Size(150, 25);
            Instalmentv.TabIndex = 8;
            Instalmentv.Visible = false;
            Instalmentv.TextChanged += Instalmentv_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 232);
            label3.Name = "label3";
            label3.Size = new Size(213, 32);
            label3.TabIndex = 9;
            label3.Text = "Amortization Table";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(20, 280);
            label4.Name = "label4";
            label4.Size = new Size(68, 25);
            label4.TabIndex = 11;
            label4.Text = "Month";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(101, 280);
            label5.Name = "label5";
            label5.Size = new Size(108, 25);
            label5.TabIndex = 12;
            label5.Text = "Starting Bal";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(227, 280);
            label6.Name = "label6";
            label6.Size = new Size(129, 25);
            label6.TabIndex = 13;
            label6.Text = "Monthly Pymt";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(378, 280);
            label7.Name = "label7";
            label7.Size = new Size(127, 25);
            label7.TabIndex = 14;
            label7.Text = "Principal Paid";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(529, 280);
            label8.Name = "label8";
            label8.Size = new Size(116, 25);
            label8.TabIndex = 15;
            label8.Text = "Interest Paid";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(664, 280);
            label9.Name = "label9";
            label9.Size = new Size(120, 25);
            label9.TabIndex = 16;
            label9.Text = "Total Interest";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(813, 280);
            label10.Name = "label10";
            label10.Size = new Size(121, 25);
            label10.TabIndex = 17;
            label10.Text = "New Balance";
            // 
            // button1
            // 
            button1.Location = new Point(550, 19);
            button1.Name = "button1";
            button1.Size = new Size(174, 73);
            button1.TabIndex = 18;
            button1.Text = "Calculate";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(773, 20);
            button2.Name = "button2";
            button2.Size = new Size(174, 72);
            button2.TabIndex = 19;
            button2.Text = "Check";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(550, 120);
            button3.Name = "button3";
            button3.Size = new Size(174, 73);
            button3.TabIndex = 20;
            button3.Text = "Search";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(773, 120);
            button4.Name = "button4";
            button4.Size = new Size(174, 73);
            button4.TabIndex = 21;
            button4.Text = "Clear";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(14, 312);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(986, 319);
            listBox1.TabIndex = 22;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            ClientSize = new Size(1055, 643);
            Controls.Add(listBox1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(Instalmentv);
            Controls.Add(label1);
            Controls.Add(interestv);
            Controls.Add(yearsv);
            Controls.Add(principalv);
            Controls.Add(years);
            Controls.Add(intrestRate);
            Controls.Add(principal);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Loan Management";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label principal;
        private Label intrestRate;
        private Label years;
        private TextBox principalv;
        private TextBox yearsv;
        private TextBox interestv;
        private Label label1;
        private TextBox Instalmentv;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private ListBox listBox1;
    }
}