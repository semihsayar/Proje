using Proje.Abstract;
using Proje.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Concrete
{
    internal class PlayerManager : IPlayerService
    {
        public void Add(Player player)
        {
            Console.WriteLine("{0} İsimli Oyuncu Aramıza Katılmıştır\n Teşekkürler {0}",player.FirstName);
        }

        public void Delete(Player player)
        {
            Console.WriteLine("{0} İsimli Oyuncu Aramızdan Ayrılmıştır/n :( {0}",player.FirstName);
        }

        public void Update(Player player)
        {
            Console.WriteLine("{0} İsimli Oyuncu Güncellenmiştir", player.FirstName);
        }
    }
}
