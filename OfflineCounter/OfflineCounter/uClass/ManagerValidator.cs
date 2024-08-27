﻿namespace OfflineCounter.uClass
{
    public class ManagerValidator
    {
        ManagerDisplay managerdisplay = new ManagerDisplay();

        ManagerLoops managerLoops = new ManagerLoops();


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

                int codestatus = 0;

                // loop para garantir que o programa seja executado enquanto a request for igual a 0.
                while (codestatus == 0)
                {
                    int statuscode = util.RequestInternet();

                    Validate_Request(statuscode);

                    codestatus = statuscode;
                } 
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

                managerLoops.LoopSystem();
            }

            if(statuscode != 0 &&  statuscode != 200)
            {
                managerdisplay.Display_CodeDiff(statuscode);
            }
        }
    }
}
