using ManyConsole;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace x12
{
    class Program
    {
        static int Main(string[] args)
        {
            try
            {
                Dispatch(args.First()); 

                return 0; 
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.ToString()); 

                return -1; 
            }
        }

        private static void Dispatch(string cmd)
        {
            switch (cmd.ToLower())
            {
                case "toxml":
                    (new ToXml()).ConvertStdIn();
                    break;
                case "format":
                    (new FormatX12()).ConvertStdIn();
                    break;
                case "tox12":
                    (new ToX12()).ConvertStdIn();
                    break;
            }
        }
    }
}
