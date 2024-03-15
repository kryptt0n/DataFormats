using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataFormats
{
    public class CreateHandler
    {

        DataStorage dataStorage;

        public CreateHandler() 
        {
            dataStorage = DataStorage.Instance;
        }

        public DataHandler Create()
        {
            string path = dataStorage.Path;
            switch (ParsePath(path))
            {
                case 0:
                    return new XMLHandler();
                case 1:
                    return new BinaryHandler();
                case 2:
                    return new TXTHandler();
                default:
                    return new ErrorHandler();
            }
        }

        private int ParsePath(string path)
        {
            string[] elements = path.Split('.');

            if (elements.Length < 2)
            {
                return -1;
            }
            string extension = elements[elements.Length - 1];
            if (extension.Equals("xml"))
                return 0;
            else if (extension.Equals("bin"))
                return 1;
            else if (extension.Equals("txt"))
                return 2;
            else
                return -1;
        }
    }
}
