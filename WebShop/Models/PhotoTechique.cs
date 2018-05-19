using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebShop.Models
{
    public class PhotoTechique
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        public double Price { get; set; }

        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        public string ImagePath { get; set; }

        public PhotoTechiqueType PhotoTechiqueType { get; set; }

        [Display(Name = "Photo Techique")]
        public int ItemId { get; set; }

        public virtual Item Item { get; set; }
    }

    public enum PhotoTechiqueType
    {
       Canon, Sony, Nikon, GoPro, Fujifilm
    }
}

