namespace MSLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //While loop
            int count = 0;
            while (count <=100)
            {
                //Code to repeat
                Console.WriteLine(count);
                count++;
            }

            //Do while loop
            count = 1;
            do
            {
                //repeat code
                Console.WriteLine(count);
                count++;
            } 
            while (count <= 10);

            //For loop (initialization; condition; increment)
            for (int i = 1; i < 16; i++)
            {
                Console.WriteLine(i);
            }

            //while with continue
            count = 0;
            while (true)
            {
                Console.WriteLine(count);
                count++;
                if(count == 3)
                {
                    continue;
                }
                Console.WriteLine("Code After");
            }
        }
    }
}
