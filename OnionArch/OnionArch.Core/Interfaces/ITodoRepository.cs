using System;
using System.Collections.Generic;
using OnionArch.Core.Model;

namespace OnionArch.Core.Interfaces
{
    public interface ITodoRepository
    {
        Guid Create(TodoItem item);

        TodoItem Retrieve(Guid id);

        void Update(TodoItem item);

        void Delete(Guid id);

        IEnumerable<TodoItem> RetrieveAll();
    }
}