using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BD_of_the_Realtor_Firm.Models
{
    public class Apartments
    {
        public long ID { get; set; }
        [Display(Name = "Код вида")]
        public long Type_ID { get; set; }
        [Display(Name = "Наименование")]
        public string Type_name { get; set; }
        [Display(Name = "Описание")]
        public string Description { get; set; }
    }
}
