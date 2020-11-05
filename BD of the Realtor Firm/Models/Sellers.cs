using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BD_of_the_Realtor_Firm.Models
{
    public class Sellers
    {
        public long ID { get; set; }
        [Display(Name = "Код продавца")]
        public long Sellers_ID { get; set; }
        [Display(Name = "ФИО")]
        public string Full_name { get; set; }
        [Display(Name = "Пол")]
        public string Gender { get; set; }
        [Display(Name = "Дата рождения")]
        public DateTime data { get; set; }
        [Display(Name = "Адрес проживания")]
        public string Address { get; set; }
        [Display(Name = "Телефон")]
        public string Phone { get; set; }
        [Display(Name = "Паспортные данные")]
        public string Passport_data { get; set; }
        [Display(Name = "Вид квартиры")]
        public DbSet<Apartments> Type_ID { get; set; }
        [Display(Name = "Код вида квартиры")]
        public long TypeID { get; set; }
        [Display(Name = "Адресс квартиры")]
        public string Address_apartament { get; set; }
        [Display(Name = "Количество комнат")]
        public int Number_rooms { get; set; }
        [Display(Name = "Площадь")]
        public int Area { get; set; }
        [Display(Name = "Отметка о раздельном санузле")]
        public string Bathroom { get; set; }
        [Display(Name = "Отметка о наличии телефона")]
        public string Mark_phone { get; set; }
        [Display(Name = "Цена")]
        public int Price { get; set; }
        [Display(Name = "Дополнительная информация")]
        public string Information { get; set; }
    }
}
