using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Project_CMS_Api.Data;
using System.Net.Http;
using Microsoft.EntityFrameworkCore;
using Project_CMS_Api.Models;
using Newtonsoft.Json;
using Microsoft.Data.SqlClient;

namespace Project_CMS_Api.Controllers
{
    public class CustomerController : Controller
    {
        private readonly COURIER_MANAGEMENT_SYSTEM_MVCContext _Db;
        HttpClient client = new HttpClient();
        string url = "https://localhost:44375/api/ConsignmentApi/";


        public CustomerController(COURIER_MANAGEMENT_SYSTEM_MVCContext Db)
        {
            _Db = Db;
        }
        public IActionResult BookConsignment(Consignment obj)
        {
            return View(obj);
        }

        [HttpPost]
        public async Task<IActionResult> Booked_Consignment(Consignment obj)
        {

            if (obj.ConsignmentId == 0)
            {
                Consignment addConsignment = new Consignment();
                addConsignment.ConsignmentBookingDate = Convert.ToDateTime(DateTime.Today);
                addConsignment.ConsignmentExpectedDate = Convert.ToDateTime(addConsignment.ConsignmentBookingDate).AddDays(5);
                addConsignment.ConsignmentStatus = "Placed";
                addConsignment.ConsignerCustomerId = obj.ConsignerCustomerId;
                addConsignment.Consignee = obj.Consignee;
                addConsignment.ConsigneeAdd = obj.ConsigneeAdd;
                addConsignment.ConsigneeCode = obj.ConsigneeCode;
                addConsignment.AssignedAgentId = ConsignmentAssignment(addConsignment.ConsigneeCode);
                //_Db.Consignments.Add(addConsignment);
                await client.PostAsJsonAsync<Consignment>(url, addConsignment);
                return View("Booked_Consignment");
            }
            else
            {
                return RedirectToAction("Error_Consignment");
            }
        }





        public int ConsignmentAssignment(int code)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = "Data Source=LAPTOP-OT25R96E;Initial Catalog=COURIER_MANAGEMENT_SYSTEM_MVC;Integrated Security=True";

                con.Open();



                SqlCommand con_assign = new SqlCommand();
                //con_assign.CommandType = System.Data.CommandType.StoredProcedure;
                con_assign.CommandText = "select top 1 agent_id from agent where @ar_code >= area_start_code and @ar_code <= area_end_code";
                con_assign.Parameters.AddWithValue("@ar_code", code);
                con_assign.Connection = con;
                var AID = con_assign.ExecuteScalar();
                int as_id_code = Convert.ToInt32(AID);
                return as_id_code;

            }
        }


        [HttpGet]
        public async Task<IActionResult> SearchConsignment(int searching)
        {
            var consignmentList = JsonConvert.DeserializeObject<List<Consignment>>(await client.GetStringAsync(url)).ToList().Where(x => x.ConsignmentId.Equals(searching)).ToList();
            return View(consignmentList);
        }


        public IActionResult Operations()
        {
            return RedirectToAction("Operations", "CustomerOperations");
        }
    }
}
