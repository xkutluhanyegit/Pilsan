using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using Core.Utilities.Security.Hashing;
using Core.Utilities.Security.JWT;
using Entities.Concrete;
using Entities.DTOs;
using Business.Constant.Messages;

namespace Business.Concrete
{
    public class AuthManager : IAuthService
    {
        private IAppUserService _appuserService;
        private ITokenHelper _tokenHelper;

        public AuthManager(IAppUserService userService, ITokenHelper tokenHelper)
        {
            _appuserService = userService;
            _tokenHelper = tokenHelper;
        }

        public IDataResult<AppUser> Register(UserForRegisterDto userForRegisterDto, string password)
        {
            byte[] passwordHash, passwordSalt;
            HashingHelper.CreatePasswordHash(password, out passwordHash, out passwordSalt);
            var user = new AppUser
            {
                Email = userForRegisterDto.Email,
                UserName = userForRegisterDto.UserName,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                Status = true
            };
            _appuserService.Add(user);
            return new SuccessDataResult<AppUser>(user, Message.UserRegistered);
        }

        public IDataResult<AppUser> Login(UserForLoginDto userForLoginDto)
        {
            var userToCheck = _appuserService.GetByMail(userForLoginDto.Email);
            if (userToCheck == null)
            {
                return new ErrorDataResult<AppUser>(Message.UserNotFound);
            }

            if (!HashingHelper.VerifyPasswordHash(userForLoginDto.Password, userToCheck.PasswordHash, userToCheck.PasswordSalt))
            {
                return new ErrorDataResult<AppUser>(Message.PasswordError);
            }

            return new SuccessDataResult<AppUser>(userToCheck, Message.SuccessfulLogin);
        }

        public IResult UserExists(string email)
        {
            if (_appuserService.GetByMail(email) != null)
            {
                return new ErrorResult(Message.UserAlreadyExists);
            }
            return new SuccessResult();
        }

        public IDataResult<AccessToken> CreateAccessToken(AppUser user)
        {
            var claims = _appuserService.GetClaims(user);
            var accessToken = _tokenHelper.CreateToken(user, claims);
            return new SuccessDataResult<AccessToken>(accessToken, Message.AccessTokenCreated);
        }
    }
}