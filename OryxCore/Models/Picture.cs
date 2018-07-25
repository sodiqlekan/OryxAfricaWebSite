using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace OryxCore.Models
{
    public class Picture
    {
        public int PictureID { get; set; }
        public string PictureName { get; set; }
        public byte[] Image { get; set; }
        public string Description { get; set; }
        public string Differentiator { get; set; }


    }
}
