namespace OfflineCounter.uClass
{
    /// <summary>
    /// Responsável por manipular os métodos que não se enquadram em outras classes.
    /// </summary>
    public class Util
    {
        /// <summary>
        /// Método que envia a requisição http para web
        /// </summary>
        /// <returns>Int contendo o statuscode da request.</returns>
        public int RequestInternet()
        {
            string url = "https://www.google.com.br";

            HttpClient httpClient = new HttpClient();
            httpClient.Timeout = TimeSpan.FromSeconds(10);

            try
            {
                var respost = httpClient.GetAsync(url).Result;
                int statuscode = (int)respost.StatusCode;

                return statuscode;
            }
            catch
            {
                // Criando um código 0.
                // Usado quando não há retorno.
                // Provavelmente devido a falta de conexão.
                return 0;
            }
        }
    }
}
