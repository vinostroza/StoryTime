using System;

namespace StoryTime
{
    class Program
    {
        static void Main(string[] args)
        {
            string yourName;
            Console.WriteLine("What is your name?");
            yourName = Console.ReadLine();
            yourName.ToLower();

            Console.WriteLine("Hello {0}", yourName);

            Console.WriteLine("Ready for a time machine to your childhood?");

            string answer = Console.ReadLine();
            answer.ToLower();
            if (answer == "yes")
            {
                Console.WriteLine("Ok, let's start a fairy tale. Make sure to press enter after accurately typing every answer as shown in every option");
            }

            else if (answer == "no")

            {
                Console.WriteLine("Well, you are no good");
            }
            else
            {
                Console.WriteLine("Start over. Stick to 'yes' or 'no'");
            }


            
            Console.WriteLine("To see your first story, press any key and then enter");
            Console.ReadLine();

            
            {
                Console.WriteLine("Welcome to the 'Three little pigs' story. Once upon a time there were three piggy brothers competing to build a house to protect themselves from the wolf. One of them finished quickly, the other one took a little longer and the third one took even longer");
            }

           

            Console.WriteLine("-Now, to see how their houses turn out and what happened, TYPE IN A HOUSE BUILDING MATERIAL. Your options are: straw, stick or brick. Go!");

            string houseMaterial = Console.ReadLine();


                 if (houseMaterial == "straw")
            {
                Console.WriteLine("Bad choice, the wolf has blown down your home");
                Console.WriteLine("Would you like to try a different material?");
                string yayNay = Console.ReadLine();
                yayNay.ToLower();
                if (yayNay == "yes")
                {
                                    }

                else if (yayNay == "no")
                {
                    {
                        Console.WriteLine("Would you like to try the 'Snow White' story?. If so, type: sw . Then press enter");
                    }
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Get out of here. You had no childhood'");
                }


                Console.WriteLine("Cool, ex out of this window,start over and type in a building material or...");
            }

                 else if (houseMaterial == "stick")
            {
                Console.WriteLine(" Sorry, your home has been blown down by the wolf");
                Console.WriteLine("Would you like to try a different material?");
                string yayNay = Console.ReadLine();
                yayNay.ToLower();
                if (yayNay == "yes")
                {
                    Console.WriteLine("Cool, ex-out of this window, start over and type in a building material... or...");
                }

                else if (yayNay == "no")
                {
                    
                    Console.WriteLine("...Would you like to try the 'Snow White' story?. If so, type: sw . Then press enter");
                    
                    string swAnswer = Console.ReadLine();
                   

                    if (swAnswer == "sw")
                    {
                        Console.WriteLine(" Welcome to 'Snow White and the seven dwarfs'");
                    } else
                    {
                        Console.WriteLine("You had no childhood. Ex-out and let someone else play");
                    }
                }


                
            }
                 else if (houseMaterial == "brick")
            { Console.WriteLine("Congratuations, your house is safe"); }
            {
                Console.WriteLine("...Would you like to try the 'Snow White' story?. If so, type: sw . Then press enter");
            }
            Console.ReadLine();

           
            {
              Console.WriteLine(" Welcome to 'Snow White and the seven dwarfs'");
           }

            Console.WriteLine("Now... have Snow White eat a fruit. Options are apple or banana");
           

            string fruit = Console.ReadLine();

                 if (fruit == "apple")
            {
                Console.WriteLine("You have poisoned Snow White, Game over");
            }
                 else if (fruit == "banana")
            { Console.WriteLine("dwarfs sing at unison:'el unico fruto del amor... es la banana, es la banana'"); }
                 else
            {
                Console.WriteLine("You are out of luck");
            }
            
            




        }
    }
}