using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Entities.DTO
{
    public class DepartmentPersonelDetailDto:HRPersonelDetailDto
    {
        public int NextWeekShiftID { get; set; }
        public string OvertimeDay { get; set; }
    }
}