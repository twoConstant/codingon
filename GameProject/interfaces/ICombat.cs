using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.interfaces
{
    public interface ICombat
    {
        int attack(int id);

        int attacked(int attackPoint);
        
    }
}
