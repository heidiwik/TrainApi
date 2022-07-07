using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using APIHelpers;
using TrainApi;

namespace TrainApi
{
    public static class TrainApi
    {
        const string url = "https://rata.digitraffic.fi/api/v1/";

        public static async Task<Station[]> GetStations()
        {
            string urlParams = "metadata/stations";

            var response = await ApiHelper.RunAsync<Station[]> (url, urlParams);
            return response;
        }
    }
}
