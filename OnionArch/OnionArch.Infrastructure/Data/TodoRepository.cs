using System;
using System.Collections.Generic;
using System.Linq;
using OnionArch.Core.Interfaces;
using OnionArch.Core.Model;

namespace OnionArch.Infrastructure.Data
{
    public class TodoRepository : ITodoRepository
    {
        private static List<TodoItem> db = new List<TodoItem>() {
            new TodoItem{
                ID = Guid.NewGuid(),
                Note = "Buy a MVC Book",
                ExpirationDate = DateTime.Now.AddMinutes(-10),
                IsCompleted = true
            },
            new TodoItem{
                ID = Guid.NewGuid(),
                Note = "Make a Saving Plan 2014",
                ExpirationDate = DateTime.Now.AddMinutes(5),
                IsCompleted = false
            }
        };

        public Guid Create(TodoItem item)
        {
            item.ID = Guid.NewGuid();
            db.Add(item);
            return item.ID;
        }

        public TodoItem Retrieve(Guid id)
        {
            return db.FirstOrDefault(i => i.ID == id);
        }

        public void Update(TodoItem item)
        {
            Delete(item.ID);
            Create(item);
        }

        public void Delete(Guid id)
        {
            db.Remove(Retrieve(id));
        }

        public IEnumerable<TodoItem> RetrieveAll()
        {
            return db;
        }
    }
}