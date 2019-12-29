using ProjectBacon.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProjectBacon.Controllers
{
    public class Api_ChecklistTasksController : ApiController
    {
        private SqlConnection conn;
        private SqlDataAdapter adapter;
        // GET: ChecklistTasks
        public IEnumerable<Tasks> GetChecklistTaskRecords(String ChecklistID)
        {
            conn = new SqlConnection("data source=SINX-HANIKO\\SQLEXPRESS;database=OpsChecklist;Integrated Security=SSPI;persist security info=True;");
            DataTable dataTable = new DataTable();
            var query = "select * from tasks where checklistid=" + ChecklistID;

            adapter = new SqlDataAdapter { SelectCommand = new SqlCommand(query, conn) };
            adapter.Fill(dataTable);

            List<Tasks> checklistTasks = new List<Models.Tasks>(dataTable.Rows.Count);

            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow taskRecord in dataTable.Rows)
                {
                    checklistTasks.Add(new Tasks(taskRecord));
                }
            }

            return checklistTasks;
        }

        // GET: api/ChecklistType/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/ChecklistType
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/ChecklistType/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/ChecklistType/5
        public void Delete(int id)
        {
        }
    }
}
