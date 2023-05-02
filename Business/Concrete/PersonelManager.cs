using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Constant.Messages;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.DTO;

namespace Business.Concrete
{
    public class PersonelManager : IPersonelService
    {
        IPersonelDal _personelDal;
        public PersonelManager(IPersonelDal personelDal)
        {
            _personelDal = personelDal;
        }

        public IDataResult<List<DepartmentPersonelDetailDto>> GetAllDepartmentPersonelDetailDto(int week, string departmentID,string overtimeDay)
        {
            var result = _personelDal.GetAllDepartmentPersonelDetailDto(week,departmentID,overtimeDay);
            return new SuccessDataResult<List<DepartmentPersonelDetailDto>>(result,Messages.ListedSuccessMessage);
        }

        public IDataResult<List<DepartmentPersonelDetailDto>> GetAllDepartmentPersonelDetailDtoWithShiftID(int week, string departmentID, int shiftID,string overtimeDay)
        {
            var result = _personelDal.GetAllDepartmentPersonelDetailDto(week,departmentID,overtimeDay).Where(p=>p.ShiftID == shiftID).ToList();
            return new SuccessDataResult<List<DepartmentPersonelDetailDto>>(result);
        }

        public IDataResult<List<HRPersonelDetailDto>> GetAllHRPersonelDetailDto(int week,string overtimeDay)
        {
            var result = _personelDal.GetAllHRPersonelDetailDto(week,overtimeDay);
            return new SuccessDataResult<List<HRPersonelDetailDto>>(result,Messages.ListedSuccessMessage);
        }
    }
}