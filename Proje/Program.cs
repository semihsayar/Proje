using Proje.Abstract;
using Proje.Concrete;
using Proje.Entity;

//  ----- Kullanıcı(Oyuncu) Tanımlama -----
Player player1 = new Player();
player1.FirstName = "Semih";
player1.LastName = "Sayar";
player1.DateOfBirth = new DateTime(2003,1,6);
player1.TcNo = "12345678910";

Player player2 = new Player();
player2.FirstName = "Engin";
player2.LastName = "Demiroğ";
player2.DateOfBirth = new DateTime(1985,1,6);
player2.TcNo = "25489565874";

// ----- Sisteme Kullanıcı(Oyuncu) Ekleme -----
IPlayerService playerManager = new PlayerManager();
playerManager.Add(player1);
Console.WriteLine("*******************");
playerManager.Add(player2);

Console.WriteLine("*******************");

// ----- Oyun Tanımlama -----
Game game1 = new Game();
game1.GameId = 1;
game1.GameName = "Payday 2 ";
game1.GamePrice = 19.20;

Game game2 = new Game();
game2.GameId = 2;
game2.GameName = "Blazing Sails";
game2.GamePrice = 17.50;

// ----- Sisteme Oyun Ekleme -----
IGameService gameManager = new GameManager();
gameManager.Add(game1);
gameManager.Add(game2);

Console.WriteLine("*******************");

// ----- Oyun Satış Yapımı -----
gameManager.Sales(game1,player2);

Console.WriteLine("*******************");

// ----- Kampanya Tanımlama -----
Campaing campaing1 = new Campaing();
campaing1.CampaingId = 1;
campaing1.CampaingName = "Bahar Kampanyası";

// ----- Sisteme Kampanya Ekleme
ICampaingService campaingManager = new CampaingManager();
campaingManager.Add(campaing1);

Console.WriteLine("*******************");

// ----- Kampanya'ya Oyun Ekleme
campaingManager.CampaingGame(campaing1, game2);



