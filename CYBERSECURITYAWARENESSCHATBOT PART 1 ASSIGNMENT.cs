using System;

namespace CyberSecurityChatBox
{

    class Program {

        
            static void Main(string[] args)
        {
            Console.Title = "Cybersecurity Awareness Bot";

            ConsoleMananger.ShowLogo();
            ConsoleMananger.ShowWelcome();
            

            string name = ConsoleMananger.GetUserName();

            SecurityBot bot = new SecurityBot(name);
            bot.StartConversation();
        }
    }
}
            
        
    
    