using darrs8.Model;
using darrs8.Service;

namespace darrs8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RunFrontEnd();
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
                    
                    var restorans = restoranService.GetAllRestoran();
                    {
                        foreach (var restoran in restorans)
                        {
                            var info = $"\nId : {restoran.Id}\nName : {restoran.Name}\nDescribtion : {restoran.Describtion}" +
                                $"\nlocation : {restoran.Location}\nMenu = {restoran.Menu}\nCapasity : {restoran.Capasity}";
                            Console.WriteLine($"{info}");
                        }
                    }
                }
                else if (option == "4")
                {
                    Console.WriteLine("Enter id to delete : ");
                    var id = Guid.Parse(Console.ReadLine());
                    var resultForm = restoranService.DeleteRestaurant(id);
                    Console.WriteLine(resultForm);
                }
                else if  (option == "3")
                {
                    Console.Write("Enter id to Update : ");
                    var id = Guid.Parse(Console.ReadLine());
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
                    var resultForm = restoranService.UpdateRestoran(restoran);
                    Console.WriteLine(resultForm);
                }
                else if  (option == "5")
                {
                    Console.WriteLine("Enter id to get : ");
                    var id = Guid.Parse(Console.ReadLine());

                    var restoran = restoranService.GetById(id);
                    var info = $"\nId : {restoran.Id}\nName : {restoran.Name}\nDescribtion : {restoran.Describtion}" +
                        $"\nlocation : {restoran.Location}\nMenu = {restoran.Menu}\nCapasity : {restoran.Capasity}";
                    Console.WriteLine(info);
                }
                Console.ReadKey();
                Console.Clear();
            }

        }
    }
}
