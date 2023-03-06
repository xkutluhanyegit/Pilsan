using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Entities.Concrete;

namespace Entities.DTOs
{
    public class PersonelDetailDto : IDto
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string SicilNo { get; set; }
        public int? ShiftId { get; set; }
        public string ShiftName { get; set; }

        public string DepId { get; set; }
        public string DepartmanName { get; set; }
        public string ServiceId { get; set; }
        public string ServiceName { get; set; }
        public string StationId { get; set; }
        public string StationName { get; set; }
        public int? WeekOfYear { get; set; }
        public string CreateDay { get; set; }
        public string Author { get; set; }

    }
}