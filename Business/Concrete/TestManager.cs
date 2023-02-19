using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Constants.Messages;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete
{
    public class TestManager : ITestService
    {
        ITestDal _testDal;
        public TestManager(ITestDal testDal)
        {
            _testDal = testDal;
        }

        public IResult Add(Test test)
        {
            _testDal.Add(test);
            return new SuccessResult(Messages.AddedMessage);
        }

        public IDataResult<List<Test>> GetAll()
        {
            var res = _testDal.GetAll();
            return new SuccessDataResult<List<Test>>(res);
        }

        public IDataResult<TestDetailDto> GetTestDetailDto()
        {
            throw new NotImplementedException();
        }
    }
}