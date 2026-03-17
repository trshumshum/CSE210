// ++++++++++++++       MAIN       ++++++++++++++
// ++++++++++++   Scripture Memorizer   ++++++++++++
// Develop 03 Prove Project - John S.
using System;

namespace ScriptureMemorizer
{
    class Program
    {
        static void Main(string[] args)
        {
            // single verse:
            //var reference = new Reference("John", 3, 16);
            //string text = "For God so loved the world that he gave his one and only Son, " +
            //           "that whoever believes in him shall not perish but have eternal life.";

            // verse range:
            var reference = new Reference("Proverbs", 3, 5, 6);
            string text = "Trust in the Lord with all your heart and lean not on your own understanding; " +
                           "in all your ways submit to him, and he will make your paths straight.";

            var scripture = new Scripture(reference, text);

            Console.Clear();
            Console.WriteLine("Scripture Memorizer");
            Console.WriteLine("Press ENTER to hide more words, or type 'quit' to exit\n");

            while (true)
            {
                Console.WriteLine(scripture);
                Console.WriteLine("\nPress ENTER or type 'quit'");

                string input = Console.ReadLine()?.Trim().ToLowerInvariant();

                if (input == "quit")
                {
                    Console.WriteLine("\nGoodbye!");
                    break;
                }

                // Hide 2–3 random visible words each turn instead of just 3.
                int wordsToHide = new Random().Next(2, 4);
                scripture.HideRandomWords(wordsToHide);

                Console.Clear(); //so you can't look back at previously exposed words.

                if (scripture.IsCompletelyHidden())
                {
                    Console.WriteLine(scripture);
                    Console.WriteLine("\nAll words hidden! Great job memorizing!");
                    Console.WriteLine("Press any key to exit..."); // added this instead of just quiting.
                    Console.ReadKey(true);
                    break;
                }
            }
        }
    }
}