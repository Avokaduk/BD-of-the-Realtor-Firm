using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BD_of_the_Realtor_Firm.Models
{
    public class Contracts
    {
        public long ID { get; set; }
        [Display(Name = "Дата заключения")]
        public DateTime Data { get; set; }
        [Display(Name = "Продавец")]
        public DbSet<Sellers> Sellers_ID { get; set; }
        [Display(Name = "Код продавца")]
        public long SellersID { get; set; }
        [Display(Name = "Покупатель")]
        public DbSet<Buyers> Buyers_ID { get; set; }
        [Display(Name = "Код покупателя")]
        public long BuyersID { get; set; }
        [Display(Name = "Сумма сделки")]
        public string amount { get; set; }
        [Display(Name = "Стоимость услуг")]
        public int Cost { get; set; }
        [Display(Name = "Вид услуг")]
        public DbSet<Servis> Type_ID { get; set; }
        [Display(Name = "Код вида услуг")]
        public long TypeID { get; set; }
        [Display(Name = "Сотрудник")]
        public DbSet<Staff> Staff_ID { get; set; }
        [Display(Name = "Код сотрудника")]
        public long StaffID { get; set; }
    }
}
