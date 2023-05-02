using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Entities.DTO
{
    public class HRPersonelDetailDto
    {
        public bool Check { get; set; }
        public string TCKN { get; set; }
        public string RegisterNo { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string DepartmanID { get; set; }
        public string DepartmanName { get; set; }
        public string ServiceID { get; set; }
        public string ServiceName { get; set; }
        public string StationID { get; set; }
        public string StationName { get; set; }
        public int? ShiftID { get; set; }
        public string ShiftName { get; set; }
        public int? OvertimeID { get; set; }
        public string OvertimeName { get; set; }
        public string OvertimeDay { get; set; }
        public int? WeekofYear { get; set; }
    }
}