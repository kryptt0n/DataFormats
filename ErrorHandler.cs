using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataFormats
{
    public class ErrorHandler : DataHandler
    {
        public ErrorHandler() { }

        public String ReadData()
        {
            return "Error occured. Wrong document type";
        }
    }
}
