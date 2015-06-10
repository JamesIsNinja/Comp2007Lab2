using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using WebApplication1.Models;
using System.Web.ModelBinding;

namespace WebApplication1
{
    public partial class students : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                getStudents();
            }
        }
        protected void getStudents()
        {
            using (Comp2007Entities db = new Comp2007Entities()) {
                //Quesry students table using enttiy frame works
                var Students = from s in db.Students select s;
                Liststudents.DataSource = Students.ToList();
                Liststudents.DataBind();
            }
        }

        protected void Liststudents_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            Int32 selectedRow = e.RowIndex;
            Int32 StudentID = Convert.ToInt32(Liststudents.DataKeys[selectedRow].Values["StudentID"]);
            using(Comp2007Entities db = new Comp2007Entities()) {

               Student s = (from obj in db.Students where obj.StudentID == StudentID select obj).FirstOrDefault();
               db.Students.Remove(s);
               db.SaveChanges();
               getStudents();
            }
        }
    }
}