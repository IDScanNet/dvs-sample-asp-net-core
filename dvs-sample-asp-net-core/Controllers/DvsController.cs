using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace dvs_sample_asp_net_core.Controllers
{
    [ApiController]
    public class DvsController : ControllerBase
    {
        private readonly HttpClient _httpClient;
        private IConfiguration _config;
        private readonly ILogger<DvsController> _logger;

        public DvsController(ILogger<DvsController> logger, IConfiguration config)
        {
            _config = config;
            _logger = logger;
            _httpClient = new HttpClient();
        }

        [HttpPost]
        [Route("/api/ValidationRequests/complete")]
        public async Task<ValidationResponse> FetchValidationRequest([FromBody] ValidationRequest request)
        {
            var bearerToken = _config.GetSection("DVSSettings").GetSection("secretKey").Value;

            var requestURL = $"https://dvs2.idware.net/api/Verify/{request.requestId}";

            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", bearerToken);

            ValidationResponse res = new ValidationResponse();
            try
            {
                HttpResponseMessage response = await _httpClient.PostAsync(requestURL, null);
                string json = await response.Content.ReadAsStringAsync();

                // 200
                if (response.IsSuccessStatusCode)
                {
                    res = JsonConvert.DeserializeObject<ValidationResponse>(json);
                }
                else
                {
                    // 400
                    if (response.StatusCode == HttpStatusCode.BadRequest)
                    {
                        _logger.LogError("Request to the DVS returned a 400 response code - Bad Request");
                    }
                    // 401
                    else if(response.StatusCode == HttpStatusCode.Unauthorized)
                    {
                        _logger.LogError("Request to the DVS returned a 401 response code - Unauthorized");
                    }
                    // 404
                    else if (response.StatusCode == HttpStatusCode.NotFound)
                    {
                        _logger.LogError("Request to the DVS returned a 404 response code - URL Not Found");
                    }
                    // 500
                    else if (response.StatusCode == HttpStatusCode.InternalServerError)
                    {
                        _logger.LogError("Request to the DVS returned a 500 response code - Internal Server Error");
                    }
                }
            }
            catch(Exception ex)
            {
                _logger.LogError("Request Failed", ex);
            }
            return res;
        }
    }
}
