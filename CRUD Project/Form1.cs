﻿using CRUD_Project.Models;

namespace CRUD_Project;

public partial class Form1 : Form
{
    CRUDContext db;
    bool Height_Bar_Animation;
    bool Width_Bar_Animation;
    int Id;
    public Form1()
    {
        InitializeComponent();
        db = new CRUDContext();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        Student_Services.LoadStudents(dataGridView1);
    }
    AddForm AddForm;
    private void Add_Button_Click(object sender, EventArgs e)
    {
        Opacity = 0.70;
        AddForm = new AddForm();
        AddForm.ShowDialog();
        Student_Services.LoadStudents(dataGridView1);
        Opacity = 1;

    }

    private void Button_Close_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void Height_Timer_Tick(object sender, EventArgs e)
    {
        if (Height_Bar_Animation)
        {

            Buttons_Panel.Height -= 7;
            if (Buttons_Panel.Height <= Buttons_Panel.MinimumSize.Height)
            {
                Height_Bar_Animation = false;
                Height_Timer.Stop();
            }
        }
        else
        {

            Buttons_Panel.Height += 7;
            if (Buttons_Panel.Height >= Buttons_Panel.MaximumSize.Height)
            {
                Height_Bar_Animation = true;
                Height_Timer.Stop();
            }
        }
    }

    private void Cancel_Button_Click(object sender, EventArgs e)
    {
        Height_Timer.Start();
        Width_Timer.Start();
        Txt_Address2.Text = Txt_Age2.Text = Txt_Lname2.Text = Txt_Fname2.Text = "";

    }

    private void Delete_Button_Click(object sender, EventArgs e)
    {
        if (MessageBox.Show("Are You Sure You Want To Delete This Row?", "Confrim Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        {
            Id = (int)dataGridView1.CurrentRow.Cells[0].Value;
            Student s = db.Students.Where(n => n.St_Id == Id).SingleOrDefault();
            db.Students.Remove(s);
            db.SaveChanges();
            MessageBox.Show("Student Removed!", "", MessageBoxButtons.OK);
            Student_Services.LoadStudents(dataGridView1);
        }
        Height_Timer.Start();

    }

    private void Update_Button_Click(object sender, EventArgs e)
    {

        Student s = db.Students.Where(n => n.St_Id == Id).SingleOrDefault();
        if (s.St_LName == Txt_Lname2.Text &&
         s.St_FName == Txt_Fname2.Text &&
         s.St_Age.ToString() == Txt_Age2.Text &&
         s.St_Address == Txt_Address2.Text &&
         s.St_DeptId == Convert.ToInt32(Cb_Dept2.SelectedValue))
        {
            MessageBox.Show("Nothing Changed!", "", MessageBoxButtons.OK);
            return;
        }
        s.St_FName = Txt_Fname2.Text;
        s.St_LName = Txt_Lname2.Text;
        s.St_Age = Convert.ToInt32(Txt_Age2.Text);
        s.St_Address = Txt_Address2.Text;
        s.St_DeptId = (int)Cb_Dept2.SelectedValue;
        db.SaveChanges();
        Txt_Address2.Text = Txt_Age2.Text = Txt_Lname2.Text = Txt_Fname2.Text = "";
        MessageBox.Show("Student Updated!", "", MessageBoxButtons.OK);
        Student_Services.LoadStudents(dataGridView1);
        Height_Timer.Start();

    }

    private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
    {
        Row_Message.Visible = false;
        Height_Bar_Animation = false;
        Height_Timer.Start();
        Width_Timer.Start();
        Id = (int)dataGridView1.CurrentRow.Cells[0].Value;
        Student s = db.Students.Where(n => n.St_Id == Id).SingleOrDefault();
        Txt_Fname2.Text = s.St_FName;
        Txt_Lname2.Text = s.St_LName;
        Txt_Age2.Text = s.St_Age.ToString();
        Txt_Address2.Text = s.St_Address;
        var departments = db.Departments.ToList();
        Cb_Dept2.DataSource = departments;
        Cb_Dept2.DisplayMember = "Dept_Name";
        Cb_Dept2.ValueMember = "DeptId";
        Cb_Dept2.SelectedValue = s.St_DeptId;
    }

    bool isCollapsed = false;

    private void Width_Timer_Tick(object sender, EventArgs e)
    {
        if (Width_Bar_Animation) 
        {
            Update_Buttons.Width -= 12;
            if (Update_Buttons.Width >= Update_Buttons.MaximumSize.Width)
            {
                Width_Timer.Stop();
                Width_Bar_Animation = false; 
            }
        }
        else 
        {
            Update_Buttons.Width += 12;
            if (Update_Buttons.Width <= Update_Buttons.MinimumSize.Width)
            {
                Width_Timer.Stop();
                Width_Bar_Animation = true; 
            }
        }
    }



}

