using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataFormats
{
    public class Pan
    {
        private DataHandler handler;

        public Pan()
        {
            ArrayList option = new ArrayList();
            option = [1, 2, 3];
            while (true)
            {
                //main control panel loop
                Console.WriteLine("Please Select the following service \n1: Input new Path\n2: Exit Program");
                string input = Console.ReadLine();
                bool result = int.TryParse(input, out int value);
                if (result == false || option.Contains(value)==false)
                {
                    Console.WriteLine("Please input the correct option");
                }
                else
                {

                    if (value == 1)
                    {
                        InputData();
                    }
                    else if (value == 2)
                    {
                        Dispaly();
                    } else if (value == 3)
                    {
                        ExitSystem();
                    }
                }
            }
        }
        
        //Catch input data and call PassDataClass
        private void InputData()
        {
            Console.WriteLine("Please input the Absoluate Path of the file");
            string data = Console.ReadLine();
            if (data == "")
            {
                Console.WriteLine("Please input the value");
            }
            PassData Path = new PassData(data);
            CreateHandler createHandler = new CreateHandler();
            handler = createHandler.CreateHandler();
            
        }
        //Exit System
        public void ExitSystem()
        {
            Console.WriteLine("Exiting Program.");
            System.Environment.Exit(0);
        }
        //Display Dataline
        public void Dispaly()
        {
            string data = handler.ReadData();
            Console.WriteLine($"The output of the data is {data}");
        }
        
    }

}
