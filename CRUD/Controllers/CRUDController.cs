using CRUD.CRUDDB;
using CRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;                                                                                                                                                                            
using System.Web.Mvc;
using System.Data.SqlClient;
using System.Data;

namespace CRUD.Controllers
{
    public class CRUDController : Controller
    {
        // GET: CRUD
        public ActionResult create()
        {
            return View();
        }


        [HttpPost]
        public ActionResult create(Student student)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source =DESKTOP-FM5RF5L\\MSSQLSERVER01; Initial Catalog =CRUD; Integrated Security = True; ");
            sqlConnection.Open();
            string query = "INSERT INTO CRUDTable values(@param1,@param2,@param3,@param4,@param5)";
            SqlCommand command = new SqlCommand(query, sqlConnection);
            command.Parameters.Add("@param1", SqlDbType.Int).Value = student.StudentNo;
            command.Parameters.Add("@param2", SqlDbType.VarChar).Value = student.Name;
            command.Parameters.Add("@param3", SqlDbType.Int).Value = student.Section;
            command.Parameters.Add("@param4", SqlDbType.VarChar).Value = student.Branch;
            command.Parameters.Add("@param5", SqlDbType.VarChar).Value = student.EmailId;
          

            command.ExecuteNonQuery();
            sqlConnection.Close();
            return RedirectToAction("Create");
        }
    }
}