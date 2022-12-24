using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DummyBazaarBerko.Models
{
    public class Category
    {
        public int ID { get; set; }

        public int? TopCategory_ID { get; set; }

        [ForeignKey("TopCategory_ID")]
        public virtual Category TopCategory { get; set; }


        [Display(Name = "Kategori Adı")]
        [Required(ErrorMessage ="Bu alan boş bırakılamaz.")]
        [StringLength(maximumLength:50, ErrorMessage ="Bu alan en fazla 50 karakter olmalıdır.")]
        public string Name { get; set; }

        [Display(Name = "Açıklama")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<Category> Categories { get; set; }
    }
}