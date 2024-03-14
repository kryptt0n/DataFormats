using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataFormats
{
    public class DataStorage
    {
        private static DataStorage? instance;

        public static DataStorage Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DataStorage();
                }
                return instance;
            }
        }
        public String Path {  get; set; }
        private DataStorage()
        {
            Path = String.Empty;
        }

    }
}
