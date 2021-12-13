using System;
using System.ComponentModel.DataAnnotations;

namespace FormsProcessingAssignment.Models
{
    public class DateAndTime
    {
        [Required]
        [Display(Name = "Number of days to Add", Description = "Number of days to Add")]
        public int NumberInput { get; set; }

        [Required]
        [Display(Name = "Enter date", Description = "Date")]
        public DateTime DateTimeInput { get; set; }

        public DateAndTime()
        {
        }
    }
}
