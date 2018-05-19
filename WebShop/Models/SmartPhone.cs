using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebShop.Models
{
    public class SmartPhone
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        public double Price { get; set; }

        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        public string ImagePath { get; set; }

        public SmartPhoneType SmartPhoneType { get; set; }

        [Display(Name = "Smart Phone")]
        public int ItemId { get; set; }

        public virtual Item Item { get; set; }
    }

    public enum SmartPhoneType
    {
        Samsung, IPhone, Huawei, Lenovo, Blackberry
    }
}

