using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcApplicationTask.Models
{
    public class MsgModels
    {
        public int Id { get; set; }

        [DataType(DataType.Text)]
        public DateTime Date { get; set; }

        [DataType(DataType.Text)]
        public string Emiteur { get; set; }

        [DataType(DataType.Text)]
        [StringLength(255,MinimumLength=6)]
        public string Contenu { get; set; }
    }
}