using Proje.Abstract;
using Proje.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Concrete
{
    internal class CampaingManager : ICampaingService
    {
        public void Add(Campaing campaing)
        {
            Console.WriteLine("{0} İsimli Kampanya Sisteme Eklenmiştir!",campaing.CampaingName);
        }

        public void Delete(Campaing campaing)
        {
            Console.WriteLine("{0} İsimli Kampanya Silinmiştir!", campaing.CampaingName);
        }

        public void Update(Campaing campaing)
        {
            Console.WriteLine("{0} İsimli Kampanya Güncellenmiştir!", campaing.CampaingName);
        }

        public void CampaingGame(Campaing campaing, Game game)
        {
            Console.WriteLine("{0} İsimli Oyunumuz, {1} İsimli Kampanyamızla Birlikte İndirime Girmiştir!",game.GameName, campaing.CampaingName);
        }
    }
}
