using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PhotoWall.Models
{
    public class Photo
    {
        public int PhotoId { get; set; }

        [Display(Name = "Foto link")]
        public string PhotoName { get; set; }

        [Display(Name = "Datum")]
        [DataType(DataType.Date)]
        public DateTime uploadDate { get; set; }
    }
}
