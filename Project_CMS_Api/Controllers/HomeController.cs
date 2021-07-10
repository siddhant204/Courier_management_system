using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Project_CMS_Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_CMS_Api.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public int GetConnection(string email, string password)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = "Data Source=LAPTOP-OT25R96E;Initial Catalog=COURIER_MANAGEMENT_SYSTEM_MVC;Integrated Security=True";

                con.Open();

                SqlCommand validator = new SqlCommand();
                //validator.CommandType = System.Data.CommandType.StoredProcedure;
                validator.CommandText = "if exists (select agent_email ,agent_pass from agent where agent_email = @em_id and agent_pass = @pass) select convert(int, 1) else if exists(select customer_email, customer_password from customer where customer_email = @em_id and customer_password = @pass) select convert(int, 2) else select convert(int, -1)";
                validator.Parameters.AddWithValue("@em_id", email);
                validator.Parameters.AddWithValue("@pass", password);
                validator.Connection = con;
                var AID = validator.ExecuteScalar();
                int code = Convert.ToInt32(AID);
                return code;

            }
        }

        [HttpGet]
        public IActionResult Account()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(Login user)
        {
            int temp = GetConnection(user.Email, user.Password);
            if (temp == 1)
            {//for agent
                return RedirectToAction("Operations", "AgentOperations");
            }
            if (temp == 2)
            {
                return RedirectToAction("Operations", "CustomerOperations");
            }
            if (user.Email == "admin" && user.Password == "password")
            {
                return RedirectToAction("Operations", "AdminOperations");

            }

            return RedirectToAction("Account", "Home");
        }


    }
}
