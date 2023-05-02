using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.DTO;

namespace Web.Models
{
    public class HRDepartmentsDetailViewModel
    {
        //GetAll
        public List<HRPersonelDetailDto> GetAllHRPersonelDetailDto { get; set; }
        public List<HRPersonelDetailDto> GetAllHRPersonelDetailShiftDto { get; set; }
        public List<HRPersonelDetailDto> GetAllHRPersonelDetailOvertimeDto { get; set; }
    }
}