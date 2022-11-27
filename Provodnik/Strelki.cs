namespace Provodnik
{
    internal class Strelki
    {
        public int[] strelki(int colvo)
        {
            int[] put = new int[2];
            int position = 0;
            int poschist = 0;
            Console.SetCursorPosition(0, position);
            Console.WriteLine("-->");
            ConsoleKeyInfo Clavisha = Console.ReadKey();
            while (true)
            {
                if (Clavisha.Key == ConsoleKey.UpArrow)
                {
                    position--;
                    if (position < 0)
                    {
                        position = colvo - 1;
                    }
                }
                else if (Clavisha.Key == ConsoleKey.DownArrow)
                {
                    position++;
                    if (position > colvo - 1)
                    {
                        position = 0;
                    }
                }
                put[0] = position;

                if (Clavisha.Key == ConsoleKey.Enter)
                {
                    return put;
                }
                else
                {
                }
                Console.SetCursorPosition(0, poschist);
                Console.WriteLine("   ");
                Console.SetCursorPosition(0, position);
                Console.WriteLine("-->");
                Clavisha = Console.ReadKey();

                poschist = position;
            }

        }
    }
}
