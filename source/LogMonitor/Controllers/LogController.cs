using System.Net;
using System.Net.Http;
using System.Web.Http;
using Microsoft.AspNet.SignalR;

namespace LogMonitor.Controllers
{
    public class LogController : ApiController
    {         
        public HttpResponseMessage Post(LogMessage message)
        {
            var hubContext = GlobalHost.ConnectionManager.GetHubContext<LogHub>();
            if (hubContext.Clients != null)
            {
                hubContext.Clients.All.updateLogs(message);
            }

            return this.Request.CreateResponse(HttpStatusCode.OK);
        }
    }

    public class LogMessage
    {
        public int? Id { get; set; }
    }
}