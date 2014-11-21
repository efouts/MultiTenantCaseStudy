using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multi_Tenant_Case_Study.Core
{
    public class ConnectionFactory
    {
        private static Func<String> connectionFactory;

        public static void SetConnectionFactory(Func<String> factory)
        {
            connectionFactory = factory;
        }

        public static String GetConnection()
        {
            return connectionFactory();
        }
    }
}
