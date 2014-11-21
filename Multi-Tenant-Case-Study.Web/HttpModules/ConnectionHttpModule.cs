using System;
using System.Web;
using Multi_Tenant_Case_Study.Core;

namespace Multi_Tenant_Case_Study.Web.HttpModules
{
    public class ConnectionHttpModule : IHttpModule
    {
        public void Init(HttpApplication context)
        {
            context.PreRequestHandlerExecute += context_PreRequestHandlerExecute;
        }

        public void Dispose()
        { }

        public void context_PreRequestHandlerExecute(object sender, EventArgs e)
        {
            var host = HttpContext.Current.Request.Headers["Host"];
            var connection = CreateConnection(host);

            var context = ((HttpApplication)sender).Context;
            context.Items["Connection"] = connection;

            ConnectionFactory.SetConnectionFactory(() => Convert.ToString(HttpContext.Current.Items["Connection"]));
        }

        private String CreateConnection(String host)
        {
            var repository = new ConnectionStringRepository();
            return repository.Get(host);
        }
    }
}