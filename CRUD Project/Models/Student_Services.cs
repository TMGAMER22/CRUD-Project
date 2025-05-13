using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Project.Models
{
    public class Student_Services
    {
        public static void LoadStudents(DataGridView dataGridView)
        {
            using (CRUDContext db = new CRUDContext())
            {
                dataGridView.DataSource = db.Students.Select(n => new { n.St_Id, n.St_FName, n.St_LName, n.St_Age, n.St_Address, DeptName = n.St_Dept.Dept_Name }).ToList();
            }
        }
    }
}
