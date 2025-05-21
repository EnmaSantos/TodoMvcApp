// File: /Models/TodoFormViewModel.cs
using System.ComponentModel.DataAnnotations;

namespace TodoMvcApp.Models
{
    public class TodoFormViewModel
    {
        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        public string Description { get; set; }

        public bool IsDone { get; set; }

        // Optional custom field just for the view
        public string PageTitle { get; set; }
    }
}