using System;
 using System.Collections.Generic;
 using System.Linq;
 using System.Threading.Tasks;
 
 namespace PlayerStats
 {
     public class Player
     {
         private float highScore;
         private int playedGames;
         private int wonGames;
 
         public string Name {get;}
 
         public Player(string name)
         {
             Name = name;
             highScore = 0;
             playedGames = 0;
             wonGames = 0;
         }
 
         public float WinRate {
             get
             {
                 if(playedGames>0)
                     return wonGames/playedGames;
                 else 
                     return 0;
             }
         }
 
         public float HighScore
         {
             get => highScore;
             set
             {
                 if (value > highScore)
                     highScore = value;
             }
         }
 
         public void PlayGame(bool win)
         {
             playedGames++;
             if (win)
                 wonGames++;
         }
     }
 }