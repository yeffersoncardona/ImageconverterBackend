using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.DTO
{
   public class ImagesDTO
    {
        public int ID { get; set; }
        [Required]
        public List<string> Names { get; set; }
        [Required]
        public string FinalSize { get; set; }
        public string User { get; set; }
        public DateTime Date { get; set; }
    }
}
