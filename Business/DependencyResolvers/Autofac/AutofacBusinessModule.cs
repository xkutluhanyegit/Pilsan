using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.Entityframework;
using Entities.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<PersonelManager>().As<IPersonelService>().SingleInstance();
            builder.RegisterType<EfPersonelDal>().As<IPersonelDal>().SingleInstance();

            builder.RegisterType<ShiftManager>().As<IShiftService>().SingleInstance();
            builder.RegisterType<EfShiftDal>().As<IShiftDal>().SingleInstance();

            builder.RegisterType<PersonelShiftManager>().As<IPersonelShiftService>().SingleInstance();
            builder.RegisterType<EfPersonelShiftDal>().As<IPersonelShiftDal>().SingleInstance();

            builder.RegisterType<PersonelOvertimeManager>().As<IPersonelOvertimeService>().SingleInstance();
            builder.RegisterType<EfPersonelOvertimeDal>().As<IPersonelOvertimeDal>().SingleInstance();

            builder.RegisterType<AppUser>().As<IdentityUser>().SingleInstance();



        }
    }
}