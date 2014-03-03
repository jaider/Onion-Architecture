using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OnionArch.UI.ViewModel;
using OnionArch.Core.Model;

namespace OnionArch.UI.Helpers
{
    public static class Mapper
    {
        public static TodoViewModel MapToTodoViewModel(TodoItem item)
        {
            return new TodoViewModel
            {
                ID = item.ID,
                Note = item.Note,
                IsCompleted = item.IsCompleted,
                ExpirationDate = item.ExpirationDate,
                CanEdit = !item.IsExpired && !item.IsCompleted
            };
        }

        public static HomeViewModel MapToHomeViewModel(IEnumerable<TodoItem> items)
        {
            return new HomeViewModel
            {
                NewTodo = new TodoNewViewModel(),
                Todos = items.Select(MapToTodoViewModel)
            };
        }
    }
}