namespace OfflineCounter.uClass
{
    public class ManagerLoops
    {
        public int loop_vezes = 0;
        int loop_miliao = 0;

        public void LoopSystem()
        {
            while (loop_miliao <= 1000000)
            {
                Console.WriteLine(loop_miliao);

                loop_miliao++;
            }

            loop_vezes++;
        }
    }
}
