using System.ComponentModel.DataAnnotations;

namespace TodoMvcApp.Models
{
    public class TodoItem
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Title is required")]
    [StringLength(100)]
    public string Title { get; set; }

    public string Description { get; set; } // Assuming this was already here
    public bool IsDone { get; set; }
    }
}