using System;
using OnionArch.Core.Model;
using System.Collections.Generic;
namespace OnionArch.Core.Interfaces
{
    public interface ITodoService
    {
        void Create(string note);

        IEnumerable<TodoItem> GetAll();

        void MarkAsCompleted(Guid id);

        void Delete(Guid id);
    }
}