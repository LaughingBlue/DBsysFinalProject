using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace DBsysFinalProject.Models
{
    public class Reminder
    {
        public int id { get; set; }

        [Required]
        public string Title { get; set; }

        public string content { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public string Datetime { get; set; }

        public Reminder()
        {
            Datetime = DateTime.Now.ToString();
        }
    }
}