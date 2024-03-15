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
            List<int> option = new List<int>();
            option.AddRange(new int[]{ 1, 2, 3});
            while (true)
            {
                //main control panel loop
                Console.WriteLine("Please Select the following service \n" +
                    "1: Input new Path\n" +
                    "2: Display content\n" +
                    "3: Exit");
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
                        Display();
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
            handler = createHandler.Create();
            
        }
        //Exit System
        public void ExitSystem()
        {
            Console.WriteLine("Exiting Program.");
            System.Environment.Exit(0);
        }
        //Display Dataline
        public void Display()
        {
            string data = handler.ReadData();
            Console.WriteLine($"The output of the data is {data}");
        }
        
    }

}
