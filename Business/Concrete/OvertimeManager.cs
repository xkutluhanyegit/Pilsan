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
    public class OvertimeManager : IOvertimeService
    {
        IOvertimeDal _overtimeDal;
        public OvertimeManager(IOvertimeDal overtimeDal)
        {
            _overtimeDal = overtimeDal;
        }
        public IResult Add(Overtime overtime)
        {
            _overtimeDal.Add(overtime);
            return new SuccessResult(Messages.AddedSuccessMessage);
        }
    }
}