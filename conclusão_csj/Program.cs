namespace Floricultura
{
    class Jardim
    {
        static void Main(string[] args)
        {
            int florzinha = Convert.ToInt32(Console.ReadLine());
            
                switch (florzinha)
                {
                    case 0: Console.WriteLine("Margarida");break;
                    case 1: Console.WriteLine("Girassol");break;
                    case 2: Console.WriteLine("Lavanda");break;
                }

            if (florzinha > 2)
            {
                Console.WriteLine("Margarida+Girassol+Lavanda");
            }

            
        }
    }
}

