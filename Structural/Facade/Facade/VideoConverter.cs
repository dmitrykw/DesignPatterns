using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    internal class VideoConverter
    {
        public void ConvertVideoFile(string filename, FileFormats format)
        {

            switch (format)
            {
                case FileFormats.MOV:
                    AppleEncoder apple_encoder = new AppleEncoder();
                    apple_encoder.EncodeMovie(filename);
                    break;

                case FileFormats.WMV:
                    WindowsMediaEncoder win_encoder = new WindowsMediaEncoder();
                    win_encoder.EncodeVideo(filename);
                    break;

                case FileFormats.MPEG:
                    DivXEncoder divx_encoder = new DivXEncoder();
                    divx_encoder.CreateMPEG4(filename);
                    break;

                default:
                    Console.WriteLine("Unknown format");
                    break;

            }
        }
    }
}
