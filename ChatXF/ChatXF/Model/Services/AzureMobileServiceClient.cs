using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChatXF.Model.Entities;
using Microsoft.WindowsAzure.MobileServices;

namespace ChatXF.Model.Services
{
    class AzureMobileServiceClient
    {
        private IMobileServiceClient _client;
        private IMobileServiceTable<Mensaje> _table;

        public AzureMobileServiceClient()
        {
            _client = new MobileServiceClient("http://chatxf.azurewebsites.net");
            _table = _client.GetTable<Mensaje>();
        }

        public Task<IEnumerable<Mensaje>> GetMensajes()
        {
            return _table.ToEnumerableAsync();
        } 
    }
}
