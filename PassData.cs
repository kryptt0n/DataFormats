using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DataFormats
{
    internal class PassData
    {
        private DataStroage storage;
        public PassData(string data)
        {
            storage = DataStroage.Instance;
            AddorReplacePath(data);
        }

        private void AddorReplacePath(string data)
        {
            storage.Path = data;
            CreateHandler handler = new CreateHandler();
        }

    }

}
