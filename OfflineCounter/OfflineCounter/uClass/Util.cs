namespace OfflineCounter.uClass
{
    public class Util
    {
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
                return 0;
            }
        }
    }
}
