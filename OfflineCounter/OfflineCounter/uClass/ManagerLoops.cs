namespace OfflineCounter.uClass
{
    /// <summary>
    /// Responsável por manipular os loops do sistema.
    /// </summary>
    public class ManagerLoops
    {
        /// <summary>
        /// Número de vezes que o sistema contou até um milhão.
        /// </summary>
        public int loop_vezes = 0;

        /// <summary>
        /// Método que conta até um milhão.
        /// </summary>
        public void LoopSystem()
        {
            int loop_miliao = 0;

            while (loop_miliao <= 1000000)
            {
                Console.WriteLine(loop_miliao);

                loop_miliao++;
            }

            loop_vezes++;
        }
    }
}
