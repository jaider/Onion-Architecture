using System.Collections.Generic;

namespace OnionArch.UI.ViewModel
{
    public class HomeViewModel
    {
        public TodoNewViewModel NewTodo { get; set; }

        public IEnumerable<TodoViewModel> Todos { get; set; }
    }
}