namespace MS._8Ball
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.OutputEncoding = System.Text.Encoding.UTF8;


            string[] answers =
            {
                "Yes, definitely.",
                "Signs pint to yes.",
                "Ask again later.",
                "I wouldn't count on it.",
                "Absolutely not.",
                "The stars are unclear.",
                "Without a doubt.",
                "My Sources say no.",
                "Nah",
                "Nuh uh"
            };

            while (true)
            {
                Console.WriteLine("=== Magic 8 Ball ===");
                Console.WriteLine("Ask a yes/no question (or press Enter to quit)");

                Console.Write("Your question: ");


                string question = Console.ReadLine();

                if (question == "") break;

                string answer = answers[Random.Shared.Next(answers.Length)];
                Console.WriteLine(answer);
            }
        }
    }
}
