using Proje.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Abstract
{
    internal interface IPlayerService
    {
        void Add(Player player);
        void Update(Player player);
        void Delete(Player player);

    }
}

