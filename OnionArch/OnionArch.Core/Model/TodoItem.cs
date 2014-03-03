using System;

namespace OnionArch.Core.Model
{
    public class TodoItem
    {
        public Guid ID { get; set; }

        public string Note { get; set; }

        public DateTime ExpirationDate { get; set; }

        public bool IsCompleted { get; set; }

        public bool IsExpired
        {
            get
            {
                return DateTime.Now.CompareTo(ExpirationDate) > 0;
            }
        }
    }
}