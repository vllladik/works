using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Planer_AspNet.Models
{
    public class PlanViewModel
    {
        
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "Title is requered")]
        [Display(Name = "Title:")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Description is requerred")]
        [Display(Name = "Description:")]
        public string Description { get; set; }
        [Display(Name = "Date")]
        public DateTime Date { get; set; }
        [Required]
        public bool IsPriority { get; set; }
        public string Img { get; set; }




    }
}

