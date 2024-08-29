namespace OfflineCounter.uClass
{
    /// <summary>
    /// Responsável por exbir layouts padrões.
    /// </summary>
    public class ManagerDisplay
    {
        /// <summary>
        /// Método que exibe a tela inicial do sistema.
        /// </summary>
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

        /// <summary>
        /// Método que exibe a tela quando statuscode for igual a 200.
        /// </summary>
        /// <param name="loop_vezes">Número de vezes que o sistema contou até um milhão.</param>
        public void Display_Code200(int loop_vezes)
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("\n                                   OFFLINE COUNTER IN MILLION                                   \n");
            Console.WriteLine("----------------------------------------------------------------------------------------------------");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("     StatusCode da requisição: 200.");
            Console.WriteLine("     Isso quer dizer que a requisição foi um sucesso!");
            Console.WriteLine("     Em outras palavras a sua internet está funcionando normalmente.");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("----------------------------------------------------------------------------------------------------");

            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine();
            Console.WriteLine($"     Número de vezes que o sistema console contou até o milhão: {loop_vezes} vezes.");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("----------------------------------------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("     Pressione ENTER para reiniciar o programa...");
            Console.WriteLine("     Pressione ESC para sair do programa...    ");
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------------------------------------------------");
        }

        /// <summary>
        /// Método que exibe a tela quando a requisição for mal sucedida.
        /// </summary>
        /// <param name="loop_vezes">Número de vezes que o sistema contou até um milhão.</param>
        public void Display_Code0(int loop_vezes)
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("\n                                   OFFLINE COUNTER IN MILLION                                   \n");
            Console.WriteLine("----------------------------------------------------------------------------------------------------");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("     StatusCode da requisição: 0.");
            Console.WriteLine("     Esse código foi criado por mim e indica falha na conexão. ");
            Console.WriteLine("     Em outras palavras a sua internet não está funcionando como deveria.");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("----------------------------------------------------------------------------------------------------");

            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine();
            Console.WriteLine($"     Número de vezes que o sistema console contou até o milhão: {loop_vezes} vezes.");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("----------------------------------------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("     Iniciciando loop em 5 segundos: contagem até o milhão...");
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------------------------------------------------");
        }

        /// <summary>
        /// Método que exibe a tela quando statuscode for diferente de 200.
        /// </summary>
        /// <param name="statuscode">Statuscode retornado pela requisição.</param>
        /// <param name="loop_vezes">Número de vezes que o sistema contou até um milhão.</param>
        public void Display_CodeDiff(int statuscode, int loop_vezes)
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("\n                                   OFFLINE COUNTER IN MILLION                                   \n");
            Console.WriteLine("----------------------------------------------------------------------------------------------------");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine($"     StatusCode da requisição: {statuscode}.");
            Console.WriteLine("     Não faço a mínima ideia do que isso significa.");
            Console.WriteLine("     Mas se houve resposta do server é sinal que está funcionando.");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("----------------------------------------------------------------------------------------------------");

            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine();
            Console.WriteLine($"     Número de vezes que o sistema console contou até o milhão: {loop_vezes} vezes.");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("----------------------------------------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("     Pressione ENTER para reiniciar o programa...");
            Console.WriteLine("     Pressione ESC para sair do programa...    ");
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------------------------------------------------");
        }
    }
}
