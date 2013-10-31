using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcApplicationTask.Models
{
    public class Task
    {
        public int Id { get; set; }

        [DataType(DataType.Text)]
        public string NomTask { get; set; }

        [DataType(DataType.Text)]
        public string Desc { get; set; }

        [DataType(DataType.Text)]
        public string contr { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd-MM-yyyy}")]
        public DateTime DateD { get; set; }

         [DataType(DataType.Date)]
        public DateTime DateF { get; set; }

        [DataType(DataType.Text)]
        public string Etat { get; set; }
    }
}