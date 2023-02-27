using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;

namespace Entities.DTOs
{
    public class PersonelInfoDto : IDto
    {
        public string SicilNo { get; set; }
        public string DepartmanName { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Shuttle { get; set; }
        public string Station { get; set; }
        public string DepartmanID { get; set; }
    }
}