using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CetBookStoreHomework.Models
{
    public class Category
    {
        public int ID { get; set; }

        [StringLength(100, MinimumLength =3)]
        [Required(ErrorMessage = "Bu alanı boş bırakamazsınız!")]
        [Display(Name="İsim")]
        public string Name { get; set; }

        public virtual List<Book> Books { get; set; }
    }
}
