using System;
using System.ComponentModel.DataAnnotations;

namespace ActivityTracker.Models
{
    public class Activity
    {
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string Name { get; set; } = string.Empty;

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [StringLength(250)]
        public string? Notes { get; set; }
    }
}