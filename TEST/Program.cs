// Mikael Feher, 2016-04-15

/* This is my first actual C# program that I wrote on my own. 
 * I wrote the actual conversational strings in Swedish since I aimed 
 * this program to possibly be the first real interaction my kids would
 * have with computers, iPads aside...
 * 
 * Simply put it asks for your name and then greets you. If you don't 
 * return the greeting, you hurt the computer's feelings. 
 * You'd better apologize!
 */




using System;


namespace MyFirstCSharpProgram
    {
    class Program
    {
        static void Main(string[] args)
        {
            string name = "";
            string userGreeting = "";
            string lowerUserGreeting = "";
            string happyPrompt = "\nTrevligt att träffas! :)))";
            string okPrompt = "\nÄh, det gör inget :)";
            string hurtPrompt = "\nJag är forfarande sårad :(";
            string rudePrompt = "Så oförskämd du är!!! :(((";


            // This is the main part of the progam that interacts with the user.

            Console.WriteLine("Vad heter du?");
            name = Console.ReadLine();
            Console.WriteLine("\nHej " + name + "!");
            userGreeting = Console.ReadLine();
            lowerUserGreeting = userGreeting.ToLower();  // Changes the user input to lowercase for easier comparison.


            // Depending on the users interaction with the program in the above section, 
            // the responses in the section below kicks in.

            if ((lowerUserGreeting == "hej") || (lowerUserGreeting == "hejsan") || (lowerUserGreeting == "trevligt att träffas"))
            {
                Console.WriteLine(happyPrompt);
            }


            while ((lowerUserGreeting != "hej") && (lowerUserGreeting != "hejsan") && (lowerUserGreeting != "trevligt att träffas"))
            {
                Console.WriteLine(rudePrompt);
                userGreeting = Console.ReadLine();
                lowerUserGreeting = userGreeting.ToLower();

                if ((lowerUserGreeting == "hej") || (lowerUserGreeting == "hejsan"))
                {
                    Console.WriteLine(hurtPrompt + "\nHälsa ordentligt nästa gång!");
                }
                else if (lowerUserGreeting == "förlåt")
                {
                    Console.WriteLine(okPrompt + "\n" + happyPrompt);
                    break;
                }
                else if (lowerUserGreeting != "förlåt")
                {
                    Console.WriteLine(hurtPrompt);
                    continue;
                }
            }
        
           
            Console.WriteLine("\n\nTryck \"ENTER\" för att avsluta");
            Console.ReadLine();
        }
    }
}
