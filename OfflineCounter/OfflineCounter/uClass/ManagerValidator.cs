namespace OfflineCounter.uClass
{
    public class ManagerValidator
    {
        ManagerLoops managerLoops = new ManagerLoops();

        ManagerDisplay managerdisplay = new ManagerDisplay();

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

                Validate_Request(statuscode);
            }
            
            if(tecla_press.Key == ConsoleKey.Escape)
            {
                Environment.Exit(0);
            }
        }

        private void Validate_Request(int statuscode)
        {
            if (statuscode == 200)
            {
                int loop_vezes = managerLoops.loop_vezes;

                managerdisplay.Display_Code200(loop_vezes);
            }

            if (statuscode == 0) 
            {
                int loop_vezes = managerLoops.loop_vezes;

                managerdisplay.Display_Code0(loop_vezes);

                Thread.Sleep(5000);
            }

            if(statuscode != 0 &&  statuscode != 200)
            {
                // Não faço a mínima ideia, mas se houve resposta é porque está funcionando
            }
        }
    }
}
