namespace CRUD_Project
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            flowLayoutPanel1 = new FlowLayoutPanel();
            Buttons_Panel = new Panel();
            Cancel_Button = new Button();
            Delete_Button = new Button();
            Update_Button = new Button();
            Add_Button = new Button();
            dataGridView1 = new DataGridView();
            Button_Close = new Button();
            Height_Timer = new System.Windows.Forms.Timer(components);
            flowLayoutPanel2 = new FlowLayoutPanel();
            Update_Buttons = new Panel();
            Cb_Dept2 = new ComboBox();
            Txt_Age2 = new TextBox();
            Txt_Address2 = new TextBox();
            Txt_Lname2 = new TextBox();
            Txt_Fname2 = new TextBox();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            Row_Message = new Label();
            Width_Timer = new System.Windows.Forms.Timer(components);
            flowLayoutPanel1.SuspendLayout();
            Buttons_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            flowLayoutPanel2.SuspendLayout();
            Update_Buttons.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(35, 71, 71);
            flowLayoutPanel1.Controls.Add(Buttons_Panel);
            flowLayoutPanel1.Location = new Point(0, 93);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(242, 306);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // Buttons_Panel
            // 
            Buttons_Panel.BorderStyle = BorderStyle.Fixed3D;
            Buttons_Panel.Controls.Add(Cancel_Button);
            Buttons_Panel.Controls.Add(Delete_Button);
            Buttons_Panel.Controls.Add(Update_Button);
            Buttons_Panel.Controls.Add(Add_Button);
            Buttons_Panel.Location = new Point(3, 3);
            Buttons_Panel.MaximumSize = new Size(0, 303);
            Buttons_Panel.MinimumSize = new Size(0, 75);
            Buttons_Panel.Name = "Buttons_Panel";
            Buttons_Panel.Size = new Size(253, 76);
            Buttons_Panel.TabIndex = 3;
            // 
            // Cancel_Button
            // 
            Cancel_Button.BackColor = Color.FromArgb(35, 71, 71);
            Cancel_Button.FlatStyle = FlatStyle.Flat;
            Cancel_Button.Font = new Font("Microsoft JhengHei", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Cancel_Button.ForeColor = Color.WhiteSmoke;
            Cancel_Button.Location = new Point(-3, 221);
            Cancel_Button.Margin = new Padding(0);
            Cancel_Button.Name = "Cancel_Button";
            Cancel_Button.Size = new Size(238, 80);
            Cancel_Button.TabIndex = 4;
            Cancel_Button.Text = "Cancel";
            Cancel_Button.UseVisualStyleBackColor = false;
            Cancel_Button.Click += Cancel_Button_Click;
            // 
            // Delete_Button
            // 
            Delete_Button.BackColor = Color.FromArgb(35, 71, 71);
            Delete_Button.FlatStyle = FlatStyle.Flat;
            Delete_Button.Font = new Font("Microsoft JhengHei", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Delete_Button.ForeColor = Color.WhiteSmoke;
            Delete_Button.Location = new Point(-3, 148);
            Delete_Button.Margin = new Padding(0);
            Delete_Button.Name = "Delete_Button";
            Delete_Button.Size = new Size(238, 71);
            Delete_Button.TabIndex = 3;
            Delete_Button.Text = "Delete";
            Delete_Button.UseVisualStyleBackColor = false;
            Delete_Button.Click += Delete_Button_Click;
            // 
            // Update_Button
            // 
            Update_Button.BackColor = Color.FromArgb(35, 71, 71);
            Update_Button.FlatStyle = FlatStyle.Flat;
            Update_Button.Font = new Font("Microsoft JhengHei", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Update_Button.ForeColor = Color.WhiteSmoke;
            Update_Button.Location = new Point(-3, 72);
            Update_Button.Margin = new Padding(0);
            Update_Button.Name = "Update_Button";
            Update_Button.Size = new Size(238, 76);
            Update_Button.TabIndex = 2;
            Update_Button.Text = "Update";
            Update_Button.UseVisualStyleBackColor = false;
            Update_Button.Click += Update_Button_Click;
            // 
            // Add_Button
            // 
            Add_Button.BackColor = Color.FromArgb(35, 71, 71);
            Add_Button.FlatStyle = FlatStyle.Flat;
            Add_Button.Font = new Font("Microsoft JhengHei", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Add_Button.ForeColor = Color.WhiteSmoke;
            Add_Button.Location = new Point(-2, -5);
            Add_Button.Margin = new Padding(0);
            Add_Button.Name = "Add_Button";
            Add_Button.Size = new Size(237, 77);
            Add_Button.TabIndex = 1;
            Add_Button.Text = "Add";
            Add_Button.UseVisualStyleBackColor = false;
            Add_Button.Click += Add_Button_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(262, 51);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(685, 340);
            dataGridView1.TabIndex = 1;
            dataGridView1.RowHeaderMouseClick += dataGridView1_RowHeaderMouseClick;
            // 
            // Button_Close
            // 
            Button_Close.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Button_Close.BackColor = Color.WhiteSmoke;
            Button_Close.BackgroundImage = (Image)resources.GetObject("Button_Close.BackgroundImage");
            Button_Close.BackgroundImageLayout = ImageLayout.Zoom;
            Button_Close.FlatAppearance.BorderColor = Color.Gainsboro;
            Button_Close.FlatAppearance.BorderSize = 0;
            Button_Close.FlatStyle = FlatStyle.Flat;
            Button_Close.Location = new Point(923, 1);
            Button_Close.Name = "Button_Close";
            Button_Close.Size = new Size(56, 44);
            Button_Close.TabIndex = 2;
            Button_Close.UseVisualStyleBackColor = false;
            Button_Close.Click += Button_Close_Click;
            // 
            // Height_Timer
            // 
            Height_Timer.Interval = 15;
            Height_Timer.Tick += Height_Timer_Tick;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackColor = Color.FromArgb(40, 40, 40);
            flowLayoutPanel2.Controls.Add(Update_Buttons);
            flowLayoutPanel2.Dock = DockStyle.Bottom;
            flowLayoutPanel2.Location = new Point(0, 397);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(980, 150);
            flowLayoutPanel2.TabIndex = 3;
            // 
            // Update_Buttons
            // 
            Update_Buttons.BackColor = Color.DimGray;
            Update_Buttons.Controls.Add(Cb_Dept2);
            Update_Buttons.Controls.Add(Txt_Age2);
            Update_Buttons.Controls.Add(Txt_Address2);
            Update_Buttons.Controls.Add(Txt_Lname2);
            Update_Buttons.Controls.Add(Txt_Fname2);
            Update_Buttons.Controls.Add(label6);
            Update_Buttons.Controls.Add(label4);
            Update_Buttons.Controls.Add(label3);
            Update_Buttons.Controls.Add(label2);
            Update_Buttons.Controls.Add(label1);
            Update_Buttons.Location = new Point(3, 3);
            Update_Buttons.MinimumSize = new Size(197, 0);
            Update_Buttons.Name = "Update_Buttons";
            Update_Buttons.Size = new Size(239, 147);
            Update_Buttons.TabIndex = 0;
            // 
            // Cb_Dept2
            // 
            Cb_Dept2.FormattingEnabled = true;
            Cb_Dept2.Location = new Point(810, 42);
            Cb_Dept2.Name = "Cb_Dept2";
            Cb_Dept2.Size = new Size(121, 23);
            Cb_Dept2.TabIndex = 11;
            // 
            // Txt_Age2
            // 
            Txt_Age2.Location = new Point(575, 42);
            Txt_Age2.Name = "Txt_Age2";
            Txt_Age2.Size = new Size(46, 23);
            Txt_Age2.TabIndex = 10;
            // 
            // Txt_Address2
            // 
            Txt_Address2.Location = new Point(575, 75);
            Txt_Address2.Name = "Txt_Address2";
            Txt_Address2.Size = new Size(102, 23);
            Txt_Address2.TabIndex = 9;
            // 
            // Txt_Lname2
            // 
            Txt_Lname2.Location = new Point(350, 77);
            Txt_Lname2.Name = "Txt_Lname2";
            Txt_Lname2.Size = new Size(78, 23);
            Txt_Lname2.TabIndex = 7;
            // 
            // Txt_Fname2
            // 
            Txt_Fname2.Location = new Point(350, 43);
            Txt_Fname2.Name = "Txt_Fname2";
            Txt_Fname2.Size = new Size(78, 23);
            Txt_Fname2.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft YaHei", 12.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(248, 43);
            label6.Name = "label6";
            label6.Size = new Size(98, 23);
            label6.TabIndex = 5;
            label6.Text = "First Name";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft YaHei", 12.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(250, 77);
            label4.Name = "label4";
            label4.Size = new Size(96, 23);
            label4.TabIndex = 3;
            label4.Text = "Last Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft YaHei", 12.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(696, 42);
            label3.Name = "label3";
            label3.Size = new Size(107, 23);
            label3.TabIndex = 2;
            label3.Text = "Department";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei", 12.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(491, 76);
            label2.Name = "label2";
            label2.Size = new Size(76, 23);
            label2.TabIndex = 1;
            label2.Text = "Address";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei", 12.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(491, 42);
            label1.Name = "label1";
            label1.Size = new Size(43, 23);
            label1.TabIndex = 0;
            label1.Text = "Age";
            // 
            // Row_Message
            // 
            Row_Message.AutoSize = true;
            Row_Message.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Row_Message.ForeColor = Color.Black;
            Row_Message.Location = new Point(19, 53);
            Row_Message.Name = "Row_Message";
            Row_Message.Size = new Size(209, 25);
            Row_Message.TabIndex = 1;
            Row_Message.Text = "Click On Any Row =>";
            // 
            // Width_Timer
            // 
            Width_Timer.Interval = 2;
            Width_Timer.Tick += Width_Timer_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(980, 547);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(Row_Message);
            Controls.Add(Button_Close);
            Controls.Add(dataGridView1);
            Controls.Add(flowLayoutPanel1);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            flowLayoutPanel1.ResumeLayout(false);
            Buttons_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            flowLayoutPanel2.ResumeLayout(false);
            Update_Buttons.ResumeLayout(false);
            Update_Buttons.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Button Add_Button;
        private Panel Buttons_Panel;
        private DataGridView dataGridView1;
        private Button Button_Close;
        private Button Delete_Button;
        private Button Update_Button;
        private Button Cancel_Button;
        private System.Windows.Forms.Timer Height_Timer;
        private FlowLayoutPanel flowLayoutPanel2;
        private Panel Update_Buttons;
        private Label label1;
        private ComboBox Cb_Dept2;
        private TextBox Txt_Address2;
        private TextBox Txt_Age2;
        private TextBox Txt_Lname2;
        private TextBox Txt_Fname2;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label2;
        private System.Windows.Forms.Timer Width_Timer;
        private Label Row_Message;
    }
}
