using System.ComponentModel.DataAnnotations;

namespace OnlineBookStore.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }
        [MaxLength(length:100)]
        public String Description { get; set; }
        public String Langauge { get; set; }

        [Required, MaxLength(length:100)]
        public string ISBN { get; set; }

        [Required,DataType(DataType.Date),Display(Name ="Date Published")]
        public DateTime DateOfPublish { get; set; }

        [Required,DataType(DataType.Currency)]
        public int Price { get; set; }

        [Required]
        public string Author { get; set; }

        [Display(Name ="Image Url")]
        public String ImageUrl { get; set; }    
    }
}
