using Proje.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Abstract
{
    internal interface IGameService
    {
        void Add(Game game);   
        void Sales(Game game, Player player);
    }
}
