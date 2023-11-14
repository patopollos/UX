using Microsoft.AspNetCore.Mvc;
using System.Net;


//namespace portalgtocore.web.ViewsComponents

namespace PaseanDog.Views.Components
{
    public class GetIpViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            IPAddress remoteIpAddress = Request.HttpContext.Connection.RemoteIpAddress;
            string sResult = "";
            if (remoteIpAddress != null)
            {
                // If we got an IPV6 address, then we need to ask the network for the IPV4 address 
                // This usually only happens when the browser is on the same machine as the server.
                if (remoteIpAddress.AddressFamily == System.Net.Sockets.AddressFamily.InterNetworkV6)
                {
                    remoteIpAddress = System.Net.Dns.GetHostEntry(remoteIpAddress).AddressList
            .First(x => x.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork);
                }
                sResult = remoteIpAddress.ToString();
            }
            ViewBag.Ip = sResult;

            return await Task.FromResult((IViewComponentResult)View("GetIp"));
        }
    }
}
