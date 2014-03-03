using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace OnionArch.UI.ViewModel
{
    public class TodoNewViewModel
    {
        [Required]
        [Display(Name = "Task Detail")]
        public string Note { get; set; }
    }
}