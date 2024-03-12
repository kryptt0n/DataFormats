using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataFormats
{
    public class DataStroage
    {
        private static DataStroage? instance;

        public static DataStroage Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DataStroage();
                }
                return instance;
            }
        }
        public String Path {  get; set; }
        private DataStroage()
        {
            Path = String.Empty;
        }

    }
}
