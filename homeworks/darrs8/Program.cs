using darrs8.Model;
using darrs8.Service;

namespace darrs8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
        public static void RunFrontEnd()
        {
            var restoranService = new RestoranService();

            while (true)
            {
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Read");
                Console.WriteLine("3. Update");
                Console.WriteLine("4. Delete");
                Console.WriteLine("5. GetById");
                Console.Write("Enter : ");
                var option = Console.ReadLine();

                if (option == "1")
                {
                    var restoran = new Restoran();
                    Console.Write("Eneter name ");
                    restoran.Name = Console.ReadLine();
                    Console.Write("Eneter describtion ");
                    restoran.Describtion = Console.ReadLine();
                    Console.Write("Eneter location ");
                    restoran.Location = Console.ReadLine();
                    Console.Write("Eneter menu ");
                    restoran.Menu = Console.ReadLine();
                    Console.Write("Eneter capasity ");
                    restoran.Capasity = int.Parse(Console.ReadLine());
                    restoran.OpenedDay = DateTime.Now;
                    
                }
                else if (option == "2")
                {
                    

                }
            }

        }
    }
}
