using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone_Week_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ////////initialize string
            string pigU;
           
            {
                //initialize bool for play again
                bool play = true;
                while (play)
                {

                    while (true)
                    {
                        try
                        {
                            Console.WriteLine("Please enter the word you'd like to translate, then press ENTER.");
                            pigU = Console.ReadLine();
                            string pig = pigU.ToLower();
                            //checks if first letter is a vowel..
                            if (pig[0] == 'a' || pig[0] == 'e' || pig[0] == 'i' || pig[0] == 'o' || pig[0] == 'u')
                            {
                                Console.WriteLine(pigU + " , in pig latin is translated to: " + pigU + "way");

                            }
                                                                                                               
                    else  
//finds the index of the first occurance of a vowel: Jacob if you're reading this. Thanks again! 
                    {int index = pig.IndexOfAny("aeiou".ToCharArray());
                            //Console.WriteLine(index);    <---- used this line to validate output while crafting program. 
                        string front = pig.Substring(0, index);
                        string end = pig.Substring(index);
                        Console.WriteLine(pigU + " , in pig latin is translated to: "+ end + front + "ay");
                    }
                            break;
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("please give me a word");
                        }

                    }

                    ///////// Option to play again 
                    //// 
                    //
                    //

                    {
                        Console.WriteLine("Would you like to translate another word? (Y/N): ");
                        string playAgain = Console.ReadLine();


                        if (playAgain == "y" || playAgain == "Y")

                        {
                            play = true;
                        }

                        else if (playAgain == "n" || playAgain == "N")

                        {
                            play = false;
                            Console.WriteLine("Thanks for playing.");
                        }
                    }
                }
            }
        }


    }
}

























            //string pigU;
            //Console.WriteLine("Please enter the word you'd like to convert, then press ENTER.");
            //pigU = Console.ReadLine();
            //string pig = pigU.ToLower(); 

            //if (pig[0] == 'a' || pig[0] == 'e'|| pig[0] == 'i' || pig[0] == 'o' || pig[0] == 'u')
            //    {
            //    Console.WriteLine(pigU + "way");
                
            //    }

            //int index = pig.IndexOfAny("aeiou".ToCharArray());

            //Console.WriteLine(index);
                                     

            //{
            //    string front = pig.Substring(0, index);
            //    string end = pig.Substring(index);
            //    Console.WriteLine(end + front + "ay");
            //}






        
    

