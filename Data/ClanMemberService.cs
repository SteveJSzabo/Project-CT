using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace TravelersChosen.Data
{
    public class ClanMemberService
    {
        private readonly IHttpClientFactory _clientFactory;
        public List<ClanMemeber> ClanMembers { get; private set; }

        public ClanMemberService(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }
        public async Task GetClanMembers()
        {
            var request = new HttpRequestMessage(HttpMethod.Get, "https://www.bungie.net/Platform/GroupV2/4328049/Members/");
            request.Headers.Add("X-API-Key", "8407f68ab5d84ed0a9026514efb6bbf2");
            var client = _clientFactory.CreateClient("bungie");
            var response = await client.SendAsync(request);
            if(response.IsSuccessStatusCode)
            {
                var responseStream = await response.Content.ReadAsStringAsync();
                var responseList = JsonConvert.DeserializeObject<ResponseData>(responseStream);
                ClanMembers = responseList.Response.results;

            }
            else
            {
                ClanMembers = new List<ClanMemeber>();
            }
        }
    }
}
