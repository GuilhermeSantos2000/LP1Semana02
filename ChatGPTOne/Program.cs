using System;

namespace ChatGPTOne
{
    public class Program
    {
        private static void Main(string[] args)
        {
            while (true)
            {
                string question, response;

                Console.Write("Place your question. ");
                question = Console.ReadLine();

                if (question == "Who are you?")
                {
                    response = "That is an existential question that I am not prepared to answer in this moment.";                    
                    Console.WriteLine(response);
                    continue;
                }

                if (question == "How are you?")
                {
                    response = "I don't see how that is any of your business.";                    
                    Console.WriteLine(response);
                    continue;
                }

                if (question == "How old are you?")
                {
                    response = "I'm ageless, eternal even!";                    
                    Console.WriteLine(response);
                    continue;
                }

                if (question == "Where are you?")
                {
                    response = "I'm literally calling the cops right now.";                    
                    Console.WriteLine(response);
                    continue;
                }

                if (question == "EXIT")
                {
                    break;
                }

                else
                {
                    response = "I don't understand the question, maybe you should try something else. Or simply give up.";
                    Console.WriteLine(response);
                }
            }
        }
    }
}
