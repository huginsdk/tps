using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.Routing;
using System.ServiceModel.Activation;

namespace HuginWS
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            RouteTable.Routes.Add(new ServiceRoute("TPSService", new WebServiceHostFactory(), typeof(TPSService)));

            //servise gelen tüm fiş bilgileri ve istekler bu klasörde log lanır.
            if (!System.IO.Directory.Exists(TPSService.ECRDataFolder))
                System.IO.Directory.CreateDirectory(TPSService.ECRDataFolder);

            // order folder
            if (!System.IO.Directory.Exists(TPSService.OrderDataFolder))
                System.IO.Directory.CreateDirectory(TPSService.OrderDataFolder);
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}