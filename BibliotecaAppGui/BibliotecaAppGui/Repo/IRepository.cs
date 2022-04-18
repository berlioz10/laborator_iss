using BibliotecaAppGui.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaAppGui.Repo
{
    public interface IRepository<T> where T : Entity
    {
        void add(T entity);
        void remove(int id);
        void update(T entity);
        T find_by_id(int id);
        IList<T> find_all();
    }
}
