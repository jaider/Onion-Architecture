using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OnionArch.Core.Model;
using OnionArch.Core.Interfaces;

namespace OnionArch.Core.Service
{
    public class TodoService : ITodoService
    {
        ITodoRepository _todoRepository;

        public TodoService(ITodoRepository todoRepository)
        {
            _todoRepository = todoRepository;
        }

        public void Create(string note)
        {
            var rand = new Random();
            var item = new TodoItem
            {
                Note = note,
                ExpirationDate = DateTime.Now.AddMinutes(rand.Next(0, 30))
            };

            _todoRepository.Create(item);
        }

        public void MarkAsCompleted(Guid id)
        {
            var item = _todoRepository.Retrieve(id);
            if (item != null)
            {
                if (item.IsExpired)
                {
                    throw new Exception("Todo item expired");
                }

                item.IsCompleted = true;
                _todoRepository.Update(item);
            }
            else
            {
                throw new Exception("Todo item doesn't exist");
            }
        }

        public IEnumerable<TodoItem> GetAll()
        {
            return _todoRepository.RetrieveAll();
        }


        public void Delete(Guid id)
        {
            _todoRepository.Delete(id);
        }
    }
}
