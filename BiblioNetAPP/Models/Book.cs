using System.ComponentModel.DataAnnotations;

namespace BiblioNetAPP.Models
{
    public class Book
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "{0} is required")]
        public string BookName { get; set; }
        public int Author { get; set; }
        
        public int Price { get; set; }

    }
}
