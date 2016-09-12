using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRPG.Models
{
    class RestfulModel
    {
        async Task<List<Unit>> FindAllUnits()
        {
            List<Unit> units = new List<Models.Unit>();
            string requestUri = "http://www.google.com";
            using (var client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(requestUri);

                if(!response.IsSuccessStatusCode)
                {
                    switch(response.StatusCode)
                    {
                        case System.Net.HttpStatusCode.NotFound:
                            return units;
                    }
                }

            }

            return units;
        }
 

    }
}
