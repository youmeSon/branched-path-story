using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your name?: ");
            string name = Console.ReadLine();
            name = name.ToUpper();
            if(name == "YOUME")
            {
                Console.WriteLine("Hey, Nick! Your name is not youme. I remember I married Nick not Youme. \n Please put your name next time! \n You cheeky boy!");
            }
            else if(name == "NICK")
            {
                Console.WriteLine($"Hello, Nick! Welcome to our story.");
            }
            else
            {
                Console.WriteLine($"Hello, {name}! Welcome to our story.");
            }
         
            Console.WriteLine("\n It begins on a cold rainy night. \n You're sitting in the living room and hear a noise coming from down the hall. \n Do you go investigate?");
            Console.WriteLine("Type YES or NO");
            string noiseChoice = Console.ReadLine();
            noiseChoice = noiseChoice.ToUpper();
            if (noiseChoice == "NO")
            {
                Console.WriteLine("Not much of an adventure if you don't leave our living room! \n THE END.");

            }
            else if (noiseChoice == "YES")
            {
                Console.WriteLine("You walk into the hallway and see a light coming from under a door down the hall. You walk towards it. \n Do you open it or knock?");
                Console.WriteLine("Type OPEN or KNOCK:");
                string doorChoice = Console.ReadLine();
                doorChoice = doorChoice.ToUpper();
                if (doorChoice == "KNOCK")
                {
                    Console.WriteLine("A voice behind the door speaks. \n It says, \"Answer this riddle: \" \n \"Poor people have it. Rich people need it. If you eat it you die. What is it?\"");
                    Console.WriteLine("Type your answer: ");
                    string riddleAnswer = Console.ReadLine();
                    riddleAnswer = riddleAnswer.ToUpper();
                    if (riddleAnswer == "NOTHING")
                    {
                        Console.WriteLine("The door opens and NOTHING is there. You turn off the light and run back to the living room and lock the door. \n Smart!! Youme kiss you. \n THE END.");
                    }
                    else
                    {
                        Console.WriteLine("You answered incorrectly. The door doesn't open. \n Go back to the room and study riddle more than coding! \n THE END. ");
                    }
                }
                else if (doorChoice == "OPEN")
                {
                    Console.WriteLine("The door is locked! See if one of your three keys will open it.");
                    Console.Write("Enter a number (1-3):");
                    int keyChoice = Convert.ToInt32(Console.ReadLine());
                    switch (keyChoice)
                    {
                        case 1:
                            Console.WriteLine("You choose the first key. Lucky choice! \n Youme suddenly come out from the hall. \n And say \"Surprise!\" \n Do you want to hug her?");
                            Console.Write("Type YES or NO:");
                            string hugAnswer = Console.ReadLine();
                            hugAnswer = hugAnswer.ToUpper();
                            string result = (hugAnswer == "YES") ? "I love you" : "Youme kicks his ass";
                            Console.WriteLine(result);
                            break;
                        case 2:
                            Console.WriteLine("You choose the second key. The door doesn't open. \n I hope you have a better luck next time.\n THE END.");
                            break;
                        case 3:
                            Console.WriteLine("You choose the third key. The door doesn't open. I hope you have a better luck next time. \n THE END.");
                            break;
                        default:
                            Console.WriteLine("You didn't choose any key between 1 to 3. \n Just go back to your room, Cheecky boy!");
                            break;
                    }
                }
                
            }
            
            
        }
    }
}
