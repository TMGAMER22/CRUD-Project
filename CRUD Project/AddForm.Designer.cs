namespace CRUD_Project
{
    partial class AddForm
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
            Txt_Fname = new TextBox();
            Txt_Lname = new TextBox();
            Txt_Age = new TextBox();
            Txt_Address = new TextBox();
            Cb_Dept = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            Button_Add_Add = new Button();
            panel2 = new Panel();
            Button_Cancel_Add = new Button();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // Txt_Fname
            // 
            Txt_Fname.Location = new Point(217, 29);
            Txt_Fname.Name = "Txt_Fname";
            Txt_Fname.Size = new Size(100, 23);
            Txt_Fname.TabIndex = 0;
            // 
            // Txt_Lname
            // 
            Txt_Lname.Location = new Point(217, 67);
            Txt_Lname.Name = "Txt_Lname";
            Txt_Lname.Size = new Size(100, 23);
            Txt_Lname.TabIndex = 1;
            // 
            // Txt_Age
            // 
            Txt_Age.Location = new Point(217, 105);
            Txt_Age.Name = "Txt_Age";
            Txt_Age.Size = new Size(38, 23);
            Txt_Age.TabIndex = 2;
            // 
            // Txt_Address
            // 
            Txt_Address.BackColor = SystemColors.Window;
            Txt_Address.Location = new Point(217, 144);
            Txt_Address.Name = "Txt_Address";
            Txt_Address.Size = new Size(100, 23);
            Txt_Address.TabIndex = 3;
            // 
            // Cb_Dept
            // 
            Cb_Dept.FormattingEnabled = true;
            Cb_Dept.Location = new Point(217, 186);
            Cb_Dept.Name = "Cb_Dept";
            Cb_Dept.Size = new Size(121, 23);
            Cb_Dept.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(108, 32);
            label1.Name = "label1";
            label1.Size = new Size(85, 20);
            label1.TabIndex = 5;
            label1.Text = "First_Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(110, 36);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 6;
            label2.Text = "____________";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(108, 70);
            label3.Name = "label3";
            label3.Size = new Size(82, 20);
            label3.TabIndex = 7;
            label3.Text = "Last_Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(110, 74);
            label4.Name = "label4";
            label4.Size = new Size(81, 20);
            label4.TabIndex = 8;
            label4.Text = "____________";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(125, 143);
            label5.Name = "label5";
            label5.Size = new Size(63, 20);
            label5.TabIndex = 9;
            label5.Text = "Address";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F);
            label6.Location = new Point(126, 147);
            label6.Name = "label6";
            label6.Size = new Size(63, 20);
            label6.TabIndex = 10;
            label6.Text = "_________";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(152, 108);
            label7.Name = "label7";
            label7.Size = new Size(36, 20);
            label7.TabIndex = 11;
            label7.Text = "Age";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11F);
            label8.Location = new Point(154, 112);
            label8.Name = "label8";
            label8.Size = new Size(33, 20);
            label8.TabIndex = 12;
            label8.Text = "____";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(64, 64, 64);
            label9.Location = new Point(108, 185);
            label9.Name = "label9";
            label9.Size = new Size(91, 20);
            label9.TabIndex = 13;
            label9.Text = "Department";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(110, 189);
            label10.Name = "label10";
            label10.Size = new Size(87, 20);
            label10.TabIndex = 14;
            label10.Text = "_____________";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(40, 40, 40);
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.Location = new Point(0, 249);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(373, 62);
            flowLayoutPanel1.TabIndex = 15;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(40, 40, 40);
            panel1.Controls.Add(Button_Add_Add);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(184, 100);
            panel1.TabIndex = 0;
            // 
            // Button_Add_Add
            // 
            Button_Add_Add.BackColor = Color.FromArgb(53, 53, 53);
            Button_Add_Add.Font = new Font("Candara", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Button_Add_Add.ForeColor = Color.Snow;
            Button_Add_Add.Location = new Point(-3, -18);
            Button_Add_Add.Name = "Button_Add_Add";
            Button_Add_Add.Size = new Size(185, 97);
            Button_Add_Add.TabIndex = 1;
            Button_Add_Add.Text = "Add";
            Button_Add_Add.UseVisualStyleBackColor = false;
            Button_Add_Add.Click += Button_Add_Add_Click;
            Button_Add_Add.MouseEnter += Button_Add_Add_MouseEnter;
            Button_Add_Add.MouseLeave += Button_Add_Add_MouseLeave;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(40, 40, 40);
            panel2.Controls.Add(Button_Cancel_Add);
            panel2.Location = new Point(182, 249);
            panel2.Name = "panel2";
            panel2.Size = new Size(191, 90);
            panel2.TabIndex = 0;
            // 
            // Button_Cancel_Add
            // 
            Button_Cancel_Add.BackColor = Color.FromArgb(53, 53, 53);
            Button_Cancel_Add.Font = new Font("Candara", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Button_Cancel_Add.ForeColor = SystemColors.ButtonHighlight;
            Button_Cancel_Add.Location = new Point(-5, -17);
            Button_Cancel_Add.Name = "Button_Cancel_Add";
            Button_Cancel_Add.Size = new Size(199, 101);
            Button_Cancel_Add.TabIndex = 2;
            Button_Cancel_Add.Text = "Cancel";
            Button_Cancel_Add.UseVisualStyleBackColor = false;
            Button_Cancel_Add.Click += Button_Cancel_Add_Click;
            Button_Cancel_Add.MouseEnter += Button_Cancel_Add_MouseEnter;
            Button_Cancel_Add.MouseLeave += Button_Cancel_Add_MouseLeave;
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(373, 311);
            Controls.Add(panel2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(Cb_Dept);
            Controls.Add(Txt_Address);
            Controls.Add(Txt_Age);
            Controls.Add(Txt_Lname);
            Controls.Add(Txt_Fname);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddForm";
            StartPosition = FormStartPosition.CenterScreen;
            Load += AddForm_Load;
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Txt_Fname;
        private TextBox Txt_Lname;
        private TextBox Txt_Age;
        private TextBox Txt_Address;
        private ComboBox Cb_Dept;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button1;
        private Button Button_Add_Add;
        private Panel panel1;
        private Panel panel2;
        private Button Button_Cancel_Add;
    }
}