namespace OfflineCounter.uClass
{
    public class ManagerDisplay
    {
        public void Display_Inicial()
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("\n                                   OFFLINE COUNTER IN MILLION                                   \n");
            Console.WriteLine("----------------------------------------------------------------------------------------------------");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("     Por que isso seria util ? Otima pergunta, e nao e.");
            Console.WriteLine("     Esse desenvolvimento foi construido somente para aprendizado.");
            Console.WriteLine();
            Console.WriteLine("     Em termos tecnicos o sistema envia uma requisicao para o nosso querido google.");
            Console.WriteLine("     Se a requisicao for bem sucedida ele encerra o loop pra que voce possa usufruir da internet.\n");

            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("----------------------------------------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("     Pressione ENTER para iniciar o programa...");
            Console.WriteLine("     Pressione ESC para sair do programa...    ");
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------------------------------------------------");
        }
    }
}
