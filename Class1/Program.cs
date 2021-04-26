using System;

namespace Class1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program lets you play the simple card game.A card is picked from a deck of cards.You have to predict whether the next card will be higher or lower.Your score in the game is the number of correct predictions you make before you guess wrong");

            
            int gamesPlayed = 0; 
            
            int sumOfScores = 0;      
                                    
            double averageScore;     
                                    
            bool playAgain;      
            
            do
            {
               int scoreThisGame;

               scoreThisGame = play(); 

               sumOfScores += scoreThisGame;

               gamesPlayed++;

               Console.WriteLine("Play again? ");
               playAgain = true;

            } while (playAgain);
            
            averageScore = ((double)sumOfScores) / gamesPlayed;
            
            Console.WriteLine("You played " + gamesPlayed + " games.");
            Console.WriteLine("Your average score was %1.3f.\n", averageScore);
        }          
          private static int play() 
          {
                                                       
            Card currentCard;  

            Card nextCard;  

            int correctGuesses ;  

            char guess;   
            
            // deck.shuffle(); 

            correctGuesses = 0;

            currentCard = guess; 

            Console.WriteLine($"The first card is the {currentCard}");
            
            while (true) 
            {    
               Console.WriteLine("Will the next card be higher (H) or lower (L)?  ");
               do 
               {
                  guess = '0';
                  // guess = TextIO.getlnChar();

                  // guess = Character.toUpperCase(guess);

                  if (guess != 'H' && guess != 'L') 
                  {
                     Console.WriteLine("Please respond with H or L:  ");
                  }
                     
               } while (correctGuesses != 'H' && correctGuesses != 'L');
               
               // nextCard = deck.();

               Console.WriteLine("The next card is " + nextCard);
               
               if (nextCard.GetType() == currentCard.GetType()) 
               {
                  Console.WriteLine("The value is the same as the previous card.");

                  Console.WriteLine("You lose on ties.  Sorry!");

                  break;  
               }
               else if (nextCard.GetType() != currentCard.GetType()) 
               {
                  if (guess == 'H') 
                  {
                     Console.WriteLine("Your prediction was correct.");

                     correctGuesses++;
                  }
                  else 
                  {
                     Console.WriteLine("Your prediction was incorrect.");

                     break; 
                  }
               }  
                  if (guess == 'L') 
                  {
                     Console.WriteLine("Your prediction was correct.");

                     correctGuesses++;
                  }
                  else 
                  {
                     Console.WriteLine("Your prediction was incorrect.");

                     break;  
                  }
                      
               currentCard = nextCard;

               Console.WriteLine();
               Console.WriteLine("The card is " + currentCard);
               
            }           
            Console.WriteLine();
            
            Console.WriteLine("The game is over.");
            Console.WriteLine("You made " + correctGuesses + "correct predictions.");

            Console.WriteLine();
            
            return correctGuesses;
         }        
    }
}
