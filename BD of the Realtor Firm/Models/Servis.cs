using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BD_of_the_Realtor_Firm.Models
{
    public class Servis
    {
        public long ID { get; set; }
        [Display(Name = "Код вида услуги")]
        public long Servis_ID { get; set; }
        [Display(Name = "Наименование")]
        public string Servis_name { get; set; }
        [Display(Name = "Описание")]
        public string Description { get; set; }
        [Display(Name = "Цена")]
        public int Price { get; set; }
    }
}
