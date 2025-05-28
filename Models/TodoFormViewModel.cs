using System.ComponentModel.DataAnnotations;

namespace TodoMvcApp.Models
{
    public class TodoFormViewModel
    {
        [Required(ErrorMessage = "Title is required")]
        public string Title { get; set; } = string.Empty;
        
        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; } = string.Empty;
        
        public bool IsDone { get; set; }
        
        public string PageTitle { get; set; } = "Todo Form";
    }
}