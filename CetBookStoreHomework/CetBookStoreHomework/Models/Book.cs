using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CetBookStoreHomework.Models
{
    public class Book
    {
        
        public int ID { get; set; }

        [Required(ErrorMessage = "Bu alanı boş bırakamazsınız!")]
        [StringLength(500, MinimumLength = 3)]
        [Display(Name ="Kitabın Adı")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Bu alanı boş bırakamazsınız!")]
        [Display(Name = "Sayfa Sayısı")]
        public int? PageCount { get; set; }

        [Required(ErrorMessage = "Bu alanı boş bırakamazsınız!")]
        [StringLength(50, MinimumLength = 3)]
        [Display(Name = "Yazar")]
        public string Authors { get; set; }

        [StringLength(250, MinimumLength = 1)]
        [Display(Name = "Açıklama")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Bu alanı boş bırakamazsınız!")]
        [Display(Name = "Fiyatı")]
        public Decimal Price { get; set;}

        [Required(ErrorMessage = "Bu alanı boş bırakamazsınız!")]
        [Display(Name = "Basım Yılı")]
        public int PressYear { get; set; }

        [Required(ErrorMessage = "Bu alanı boş bırakamazsınız!")]
        [Display(Name = "Stok Durumu")]
        public int StockCount { get; set; }

        
        public int CategoryID { get; set; }

        public Category Category { get; set; }

        [Display(Name = "Oluşturulduğu Tarih")]
        public DateTime CreatedDate { get; set; }

        public virtual List<Comment> Comments { get; set; }

        public Book()
        {
            CreatedDate = DateTime.Now;
        }
    }
}
