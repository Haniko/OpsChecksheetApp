using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ProjectBacon.Models
{
    public class Tasks
    {

        public Tasks() { }

        public Tasks(DataRow tasks)
        {
            Id = Convert.ToInt32(tasks["Id"]);
            ChecklistID = Convert.ToInt32(tasks["ChecklistID"]);
            Description = tasks["Description"].ToString();
            Link = tasks["Link"].ToString();
            Status = Convert.ToInt32(tasks["Status"]);
        }

        public int Id { get; set; }
        public int ChecklistID { get; set; }
        public String Description { get; set; }
        public String Link { get; set; }
        public int Status { get; set; }
    }

}