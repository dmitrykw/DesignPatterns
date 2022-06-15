using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VideoConverter converter = new VideoConverter();
            converter.ConvertVideoFile("somevideo.avi", FileFormats.WMV);
            converter.ConvertVideoFile("somevideo.avi", FileFormats.MPEG);
            converter.ConvertVideoFile("somevideo.avi", FileFormats.MOV);
            Console.ReadLine();
        }
    }
}
