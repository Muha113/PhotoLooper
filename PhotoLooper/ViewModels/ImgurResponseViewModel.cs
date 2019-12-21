using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhotoLooper.ViewModels
{
    public class ImgurResponseViewModel
    {
        public ImgurImageDataViewModel Data { get; set; }
        public bool Success { get; set; }
        public int Status { get; set; }
    }
}
