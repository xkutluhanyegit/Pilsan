using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Utilities.Results.Abstract;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IAppUserService
    {
        IResult Add(AppUser appUser);
        IDataResult<List<AppUser>> GetAll();
    }
}