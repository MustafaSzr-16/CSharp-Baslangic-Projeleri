
using System;
class HelloWorld {
  static void Main() {
    Console.Write("oyuncu ismi: ");           //cristiano 
string playerName = Console.ReadLine();  

Console.Write("Oyuncu soyadı: ");        //ronaldo
string playerSurname = Console.ReadLine().ToUpper();

Console.Write("takımı: ");              //real madrid
string team = Console.ReadLine();

Console.Write("oyuncunun hızı: ");     // hızı 80 alın
int playerSpeed = Convert.ToInt32(Console.ReadLine());

Console.Write("oyuncunun  şut değeri: ");     // şutu 90 alın
int playerShoot = Convert.ToInt32(Console.ReadLine());

Console.Write("oyuncunun pas değeri: ");      // pası 75 alın
int playerPass = Convert.ToInt32(Console.ReadLine());

int playerOverall = (playerSpeed + playerShoot + playerPass) / 3;

Console.WriteLine($"oyuncunun adı {playerName} oyuncunun soyadı {playerSurname} oyuncunun takımı {team}");
Console.WriteLine("oyuncunun genel reytingi "+playerOverall);


  }
}