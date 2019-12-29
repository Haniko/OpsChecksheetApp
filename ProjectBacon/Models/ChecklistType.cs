using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ProjectBacon.Models
{
    public class ChecklistType
    {

        public ChecklistType() { }

        public ChecklistType(DataRow checklistTypeRecord)
        {
            Id = Convert.ToInt32(checklistTypeRecord["Id"]);
            Name = checklistTypeRecord["Name"].ToString();
        }

        public int Id { get; set; }
        public String Name { get; set; }
    }

}