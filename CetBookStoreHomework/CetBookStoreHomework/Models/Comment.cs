using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CetBookStoreHomework.Models
{
    public class Comment
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Bu alanı boş bırakamazsınız!")]
        [Display(Name = "Başlık")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Bu alanı boş bırakamazsınız!")]
        [Display(Name = "Yorum")]
        public string Detail { get; set; }

        [Display(Name = "Oy")]
        public int? Rating { get; set; }

        [Display(Name = "Oluşturulduğu Tarih")]
        public DateTime CreatedDate { get; set; }

        public int BookID { get; set; }

        public Book Book { get; set; }
    }
}
