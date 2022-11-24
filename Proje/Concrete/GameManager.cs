using Proje.Abstract;
using Proje.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Concrete
{
    internal class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine("{0} İsimli Oyun Sisteme Eklenmiştir!",game.GameName);
        }

        public void Sales(Game game, Player player)
        {
            Console.WriteLine("{0} İsimli Kullanıcımız {1} İsimli Oyunu Satın Aldı!",player.FirstName, game.GameName);
        }
    }
}
