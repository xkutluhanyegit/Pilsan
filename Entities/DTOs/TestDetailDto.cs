using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;

namespace Entities.DTOs
{
    public class TestDetailDto : IDto
    {
        //DTOs
        public int a { get; set; }
        public int b { get; set; }
        public int c { get; set; }
    }
}