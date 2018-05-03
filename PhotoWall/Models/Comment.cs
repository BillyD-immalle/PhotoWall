using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PhotoWall.Models
{
    public class Comment
    {
        public int Id { get; set; }

        [Display(Name = "Gebruiker")]
        public string User { get; set; }

        [Display(Name = "Reactie")]
        public string Commentary { get; set; }

        [Display(Name = "Datum")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
    }
}
