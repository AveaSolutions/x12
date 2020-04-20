
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace x12
{
    class ToX12
    {
        public void ConvertStdIn()
        {
            var parser = new OopFactory.X12.Parsing.X12Parser();

            var xml = Console.In.ReadToEnd(); 

            Console.Out.Write(parser.TransformToX12(xml));
        }
    }
}
