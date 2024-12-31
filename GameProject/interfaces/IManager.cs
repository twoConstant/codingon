using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.interfaces
{
    public interface IManager<T>
    {
        void Add(T item);
        T FindById(int id);
        void Remove(T item);

    }
}
