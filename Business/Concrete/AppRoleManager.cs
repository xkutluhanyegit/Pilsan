using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Constant.Messages;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation.FluentValidation;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using FluentValidation;

namespace Business.Concrete
{
    public class AppRoleManager : IAppRoleService
    {
        IAppRoleDal _appRoleDal;
        public AppRoleManager(IAppRoleDal appRoleDal)
        {
            _appRoleDal = appRoleDal;
        }

        // [ValidationAspect(typeof(RolValidator), Priority = 1)]
        public IResult Add(AppRole appRole)
        {
            // var validContext = new ValidationContext<AppRole>(appRole);
            // RolValidator rolValidator = new RolValidator();
            // var validRes = rolValidator.Validate(appRole);

            // if (validRes.IsValid)
            // {
            //     _appRoleDal.Add(appRole);
            //     return new SuccessResult(Message.AddedSuccess);
            // }
            // else
            // {
            //     return new ErrorResult(validRes.Errors.ToString());
            // }

            _appRoleDal.Add(appRole);
            return new SuccessResult(Message.AddedSuccess);


        }

        public IDataResult<List<AppRole>> GetAll()
        {
            var res = _appRoleDal.GetAll();
            return new SuccessDataResult<List<AppRole>>(res, Message.AddedSuccess);
        }
    }
}