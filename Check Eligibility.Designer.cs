namespace Loan_Calculator
{
    partial class Check_Eligibility
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
            comboBox1 = new ComboBox();
            loanTypev = new Label();
            label1 = new Label();
            eligibility = new TextBox();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            label2 = new Label();
            label3 = new Label();
            cusIdv = new TextBox();
            cusNamev = new TextBox();
            monthlyIncomev = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Car Loan", "Personal Loan", "Housing Loan" });
            comboBox1.Location = new Point(223, 31);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(165, 33);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // loanTypev
            // 
            loanTypev.AutoSize = true;
            loanTypev.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            loanTypev.Location = new Point(15, 28);
            loanTypev.Name = "loanTypev";
            loanTypev.Size = new Size(152, 32);
            loanTypev.TabIndex = 1;
            loanTypev.Text = "Type of Loan";
            loanTypev.Click += loanTypev_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(13, 78);
            label1.Name = "label1";
            label1.Size = new Size(147, 32);
            label1.TabIndex = 2;
            label1.Text = "Customer ID";
            // 
            // eligibility
            // 
            eligibility.BackColor = SystemColors.Control;
            eligibility.BorderStyle = BorderStyle.None;
            eligibility.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            eligibility.Location = new Point(131, 231);
            eligibility.Name = "eligibility";
            eligibility.ReadOnly = true;
            eligibility.Size = new Size(150, 29);
            eligibility.TabIndex = 9;
            eligibility.Visible = false;
            eligibility.TextChanged += eligibility_TextChanged;
            // 
            // button4
            // 
            button4.Location = new Point(162, 292);
            button4.Name = "button4";
            button4.Size = new Size(95, 39);
            button4.TabIndex = 25;
            button4.Text = "Clear";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(281, 292);
            button3.Name = "button3";
            button3.Size = new Size(95, 39);
            button3.TabIndex = 24;
            button3.Text = "Save";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(35, 292);
            button2.Name = "button2";
            button2.Size = new Size(95, 39);
            button2.TabIndex = 23;
            button2.Text = "Check";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(15, 228);
            label2.Name = "label2";
            label2.Size = new Size(110, 32);
            label2.TabIndex = 26;
            label2.Text = "Eligibility";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(15, 128);
            label3.Name = "label3";
            label3.Size = new Size(188, 32);
            label3.TabIndex = 27;
            label3.Text = "Customer Name";
            // 
            // cusIdv
            // 
            cusIdv.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            cusIdv.Location = new Point(221, 78);
            cusIdv.Name = "cusIdv";
            cusIdv.Size = new Size(175, 32);
            cusIdv.TabIndex = 28;
            // 
            // cusNamev
            // 
            cusNamev.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            cusNamev.Location = new Point(222, 128);
            cusNamev.Name = "cusNamev";
            cusNamev.Size = new Size(150, 32);
            cusNamev.TabIndex = 29;
            // 
            // monthlyIncomev
            // 
            monthlyIncomev.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            monthlyIncomev.Location = new Point(223, 177);
            monthlyIncomev.Name = "monthlyIncomev";
            monthlyIncomev.Size = new Size(150, 32);
            monthlyIncomev.TabIndex = 31;
            monthlyIncomev.TextChanged += monthlyIncomev_TextChanged;
            monthlyIncomev.KeyPress += monthlyIncomev_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(15, 177);
            label4.Name = "label4";
            label4.Size = new Size(190, 32);
            label4.TabIndex = 30;
            label4.Text = "Monthly Income";
            // 
            // Check_Eligibility
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(421, 343);
            Controls.Add(monthlyIncomev);
            Controls.Add(label4);
            Controls.Add(cusNamev);
            Controls.Add(cusIdv);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(eligibility);
            Controls.Add(label1);
            Controls.Add(loanTypev);
            Controls.Add(comboBox1);
            Name = "Check_Eligibility";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Check_Eligibility";
            FormClosing += Check_Eligibility_FormClosing;
            Load += Check_Eligibility_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label loanTypev;
        private Label label1;
        private TextBox eligibility;
        private Button button4;
        private Button button3;
        private Button button2;
        private Label label2;
        private Label label3;
        private TextBox cusIdv;
        private TextBox cusNamev;
        private TextBox monthlyIncomev;
        private Label label4;
    }
}