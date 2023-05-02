using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Constant.Messages;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class ShiftManager : IShiftService
    {
        IShiftDal _shiftDal;
        public ShiftManager(IShiftDal shiftDal)
        {
            _shiftDal =shiftDal;
        }
        public IDataResult<List<Shift>> GetAllShift()
        {
            var result = _shiftDal.GetAll();
            return new SuccessDataResult<List<Shift>>(result,Messages.ListedSuccessMessage);
        }
    }
}