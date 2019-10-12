using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Contract.Response;

namespace Api.Controllers
{
    [Produces("application/json")]
    [Route("api/info")]
    public class InfoController : Controller
    {
        /// <summary>
        /// This is a simple interface to test connectivity.
        /// </summary>
        /// <returns>A string with the Current date and time.</returns>
        [HttpGet("heartbeat")]
        public HeartbeatResponse Heartbeat()
        {
            return new HeartbeatResponse() { Message = string.Format("The current time is: {0}", DateTime.Now.ToLongTimeString()) };
        }
    }
}


var queryResult = await mongoQueryExecuter.ExecutQueryAsync<HtmlPdfDocument>(nativeQuery, queryOption);
List<string> invalidResults = new List<string>();
if (queryResult.Records.Count > 0)
{
    var tempResults = queryResult.Records as List<HtmlPdfDocument>;
    tempResults.ForEach(res => invalidResults.Add(res.DocumentId));
}

return invalidResults;
