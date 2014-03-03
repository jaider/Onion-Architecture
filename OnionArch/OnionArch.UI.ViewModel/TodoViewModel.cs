using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace OnionArch.UI.ViewModel
{
    public class TodoViewModel
    {
        public Guid ID { get; set; }

        [Display(Name = "Task Detail")]
        public string Note { get; set; }

        public DateTime ExpirationDate { get; set; }

        [Display(Name = "Done?")]
        public bool IsCompleted { get; set; }
        
        public bool CanEdit { get; set; }

        [Display(Name = "Time Left")]
        public string TimeLeft {
            get
            {
                if (IsCompleted)
                {
                    return "Perfect";
                }

                var time = ExpirationDate.Subtract(DateTime.Now);
                return time.TotalMinutes < 0 ? "Oops Timeout" : string.Format("{0} min {1} secs", time.Minutes, time.Seconds);
            }
        }
    }
}