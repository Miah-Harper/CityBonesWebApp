//using CityBonesWebApp.Models;
//using Microsoft.AspNetCore.Mvc;
//using MySql.Data.MySqlClient;
//using System.Data;

//namespace CityBonesWebApp.Controllers
//{
//    public class LoginController : Controller
//    {

//        public string value = "";

//        [HttpGet]
//        public ActionResult Index()
//        {
//            return View();
//        }

//        [HttpPost]
//        public ActionResult Index(Login e)
//        {
//            if (Request.HttpMethod == "POST")
//            {
//                Login er = new Login();
//                using (IDbConnection con = new MySqlConnection())
//                {
//                    using( = new SqlCommand("SP_EnrollDetail", con))
//                    {
//                        cmd.CommandType = CommandType.StoredProcedure;
//                        cmd.Parameters.AddWithValue("@FirstName", e.FirstName);
//                        cmd.Parameters.AddWithValue("@LastName", e.LastName);
//                        cmd.Parameters.AddWithValue("@Password", e.Password);
                       
//                        cmd.Parameters.AddWithValue("@Email", e.Email);
                       
                        
//                        cmd.Parameters.AddWithValue("@status", "INSERT");
//                        con.Open();
//                        ViewData["result"] = cmd.ExecuteNonQuery();
//                        con.Close();
//                    }
//                }
//            }
//            return View();
//        }
//    }
//}
