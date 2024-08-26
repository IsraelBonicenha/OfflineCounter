namespace OfflineCounter.uClass
{
    public class ManagerValidator
    {
        public void Validate_KeyPress_One()
        {
            var tecla_press = Console.ReadKey();

            while (tecla_press.Key != ConsoleKey.Enter && tecla_press.Key != ConsoleKey.Escape) 
            {
                tecla_press = Console.ReadKey();
            }

            if (tecla_press.Key == ConsoleKey.Enter)
            {
                Util util = new Util();

                int statuscode = util.RequestInternet();
            }
            
            if(tecla_press.Key == ConsoleKey.Escape)
            {
                Environment.Exit(0);
            }
        }
    }
}
