using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.DataAccess;
using Entities.Concrete;
using Entities.DTO;

namespace DataAccess.Abstract
{
    public interface IPersonelDal:IEntityRepository<Personel1>
    {
        List<HRPersonelDetailDto> GetAllHRPersonelDetailDto(int week,string overtimeDay);
        List<DepartmentPersonelDetailDto> GetAllDepartmentPersonelDetailDto(int week,string departmentID, string overtimeDay);
    }
}