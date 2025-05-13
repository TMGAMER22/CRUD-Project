using CRUD_Project.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_Project
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void Button_Add_Add_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(Txt_Fname.Text) || String.IsNullOrWhiteSpace(Txt_Lname.Text) || String.IsNullOrWhiteSpace(Txt_Age.Text) || String.IsNullOrWhiteSpace(Txt_Address.Text))
            {
                MessageBox.Show("Please fill all fields");
            }
            else
            {
                Student s = new Student()
                {
                    St_FName = Txt_Fname.Text,
                    St_LName = Txt_Lname.Text,
                    St_Age = Convert.ToInt32(Txt_Age.Text),
                    St_Address = Txt_Address.Text,
                    St_DeptId = (int)Cb_Dept.SelectedValue
                };
                using (CRUDContext db = new CRUDContext())
                {
                    db.Students.Add(s);
                    db.SaveChanges();
                    MessageBox.Show("Student Added Successfully");
                    this.Close();

                }
            }


        }

        private void AddForm_Load(object sender, EventArgs e)
        {
            using (CRUDContext db = new CRUDContext())
            {
                Cb_Dept.DataSource = db.Departments.ToList();
                Cb_Dept.DisplayMember = "Dept_Name";
                Cb_Dept.ValueMember = "DeptId";

            }
        }

        private void Button_Cancel_Add_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void Button_Cancel_Add_MouseEnter(object sender, EventArgs e)
        {
            Button_Cancel_Add.Font = new Font("Candara", 16, FontStyle.Bold);
        }
        private void Button_Cancel_Add_MouseLeave(object sender, EventArgs e)
        {
            Button_Cancel_Add.Font = new Font("Candara", 14, FontStyle.Bold);

        }
        private void Button_Add_Add_MouseEnter(object sender, EventArgs e)
        {
            Button_Add_Add.Font = new Font("Candara", 16, FontStyle.Bold);

        }
        private void Button_Add_Add_MouseLeave(object sender, EventArgs e)
        {
            Button_Add_Add.Font = new Font("Candara", 14, FontStyle.Bold);

        }
    }
}
