using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_App.Models.Enums;

namespace Task_App.Models
{
    public class TaskItem
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; } = string.Empty;

        public string? Description { get; set; }

        //public DateTime CreatedDate { get; set; } = DateTime.Now;

        //public DateTime? DueDate { get; set; }

        //public bool IsCompleted { get; set; }

        //public Priority Priority { get; set; } = Priority.Medium;

        //public int CategoryId { get; set; }

        //public Category? Category { get; set; }
    }
}
