/* This is ana ssignment for LDIL Cohort 1. 
 * This assignment implements loops inorder to print a and mimick a song sang 
 * Used a do while becuase we always need a first iteration. Could've used a for loop, a foreach loop or a while
 */

namespace MorwakgadiMamabolo_Assignment1_Loops
{

    public class BeerSong
    {
        public void Sing()
        {
            int bottleNumber = 99; //initilaize the varibale bottle with 99. we are staring at 99. 

            do
            {
                //condition to check if we havent reached our base condition. if we do then exit the loop; 
                if (bottleNumber > 1)
                {
                    Console.WriteLine($"{bottleNumber} bottles of beer on the wall, {bottleNumber} bottles of beer.");
                    Console.WriteLine($"Take one down and pass it around, {bottleNumber - 1} bottles of beer on the wall.");
                   
                }
                else
                {
                    Console.WriteLine("1 bottle of beer on the wall, 1 bottle of beer.");
                    Console.WriteLine("Take one down and pass it around, no more bottles of beer on the wall.");
                }

                Console.WriteLine();
                bottleNumber--; // the -- is called a decriment. it performs the same function as bottleNumber -=1 or bottleNumber = bottleNumber -1

            } while (bottleNumber > 0);

            Console.WriteLine("No more bottles of beer on the wall, no more bottles of beer.");

        }
    }

    //the program starts running from here. This is the class where our main function is contained. 
    class Program
    {
        static void Main()
        {
            BeerSong song = new BeerSong(); // creating an instance of the class Beer
            song.Sing(); // calling the function Sing. 
        }
    }


}
