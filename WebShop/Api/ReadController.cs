using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Web.Http;
using System.Net.Http;
using WebShop.DAL;
using System.Data.SqlClient;
using System.Configuration;


namespace WebShop.Api
{
    public class GetUserController : ReadController
    {
        public GetUserController() : base(SQL.Users) { }
    }


    #region
    public abstract class ReadController : ApiController
    {
        public string SqlStr { get; set; }

        public ReadController(string sqlStr)
        {
            SqlStr = sqlStr;
        }

        // GET api/<controller>/5
        public HttpResponseMessage Get(int id=0)
        {
            DataTable dt = new DataTable();
            var connStr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

            using (SqlConnection con = new SqlConnection(connStr))
            {
                using (var da = new SqlDataAdapter(SqlStr, con))
                {
                    da.Fill(dt);
                }
            }

            var response = Request.CreateResponse(HttpStatusCode.OK, dt, "application/json");
            return response;
        }
    }
    #endregion
}