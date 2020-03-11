using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xrm.Sdk;
using Newtonsoft.Json;


namespace mgronbec.plugins.securedFieldDownload
{
    public class downloadField : IPlugin
    {
        private readonly string _unsecureString;
        private readonly string _secureString;
        public downloadField(string unsecureString, string secureString)
        {
            if (String.IsNullOrWhiteSpace(unsecureString) ||
                String.IsNullOrWhiteSpace(secureString))
            {
                throw new InvalidPluginExecutionException("Unsecure and secure strings are required for this plugin to execute.");
            }

            _unsecureString = unsecureString;
            _secureString = secureString;
        }
        public void Execute(IServiceProvider serviceProvider)
        {
            try
            {

            }
            catch(InvalidPluginExecutionException)
            {
                throw;
            }
            catch(Exception)
            {
                throw;
            }
        }
    }
    public class configParams
    {
        public string Entity { get; set; }
        public string Attribute { get; set; }

    }
}
