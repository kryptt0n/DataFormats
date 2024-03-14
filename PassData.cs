using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DataFormats
{
    public class PassData
    {
        private DataStorage storage;
        public PassData(string data)
        {
            storage = DataStorage.Instance;
            AddorReplacePath(data);
        }

        private void AddorReplacePath(string data)
        {
            storage.Path = data;
        }

    }

}
