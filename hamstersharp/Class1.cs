using Newtonsoft.Json;
using RestSharp;

namespace hamstersharp
{
    public class Client
    {
        private string token;
        private RestClient httpclient;
        /// <summary>
        /// Initialize a client to work with the API
        /// </summary>
        /// <param name="token">A HamsterKombat API token. In the "Bearer XXXXXX" format</param>
        /// <param name="timeout">Timeout (in seconds) before an API request is terminated</param>
        public Client(string token, double timeout = 30)
        {
            this.token = token;
            httpclient = new RestClient(options:new RestClientOptions() { BaseUrl = Data.Data.baseURI, Timeout = TimeSpan.FromSeconds(timeout) });
        }

        /// <summary>
        /// Gets all account info. (the /sync endpoint)
        /// </summary>
        /// <returns>An AccountInfo object</returns>
        /// <exception cref="Exceptions.Auth.InvalidTokenException"></exception>
        /// <exception cref="Exceptions.Auth.NullResponseContent"></exception>
        /// <exception cref="Exceptions.System.ParsingException"></exception>
        public Structures.AccountInfo.AccountInfo GetInfo()
        {
            RestRequest request = new RestRequest(Data.Data.infoPath, Method.Post);
            request.AddHeader("Authorization", token);
            RestResponse response = httpclient.Execute(request);
            if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized) throw new Exceptions.Auth.InvalidTokenException();
            if (!response.IsSuccessStatusCode || response.Content == null)
                throw new Exceptions.Auth.NullResponseContent((int)response.StatusCode);
            Structures.AccountInfo.AccountInfo? obj = JsonConvert.DeserializeObject<Structures.AccountInfo.AccountInfo>(response.Content);
            if (obj == null) throw new Exceptions.System.ParsingException();
            return obj;
        }

        /// <summary>
        /// Gets all upgrades (cards). (the /upgrades-for-buy endpoint)
        /// </summary>
        /// <returns>An Upgrade[] list</returns>
        /// <exception cref="Exceptions.Auth.InvalidTokenException"></exception>
        /// <exception cref="Exceptions.Auth.NullResponseContent"></exception>
        /// <exception cref="Exceptions.System.ParsingException"></exception>
        public Structures.Upgrades.Upgrade[] GetUpgrades()
        {
            RestRequest request = new RestRequest(Data.Data.getUpgradesPath, Method.Post);
            request.AddHeader("Authorization", token);
            RestResponse response = httpclient.Execute(request);
            if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized) throw new Exceptions.Auth.InvalidTokenException();
            if (!response.IsSuccessStatusCode || response.Content == null)
                throw new Exceptions.Auth.NullResponseContent((int)response.StatusCode);
            Structures.Upgrades.Upgrades? obj = JsonConvert.DeserializeObject<Structures.Upgrades.Upgrades>(response.Content);
            if (obj == null) throw new Exceptions.System.ParsingException();
            return obj.upgradesForBuy;
        }
    }
}
