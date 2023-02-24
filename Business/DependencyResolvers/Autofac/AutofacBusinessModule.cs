using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;

namespace Business.DependencyResolvers.Autofac
{
    //IOC
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //No Data
            builder.RegisterType<AppRoleManager>().As<IAppRoleService>().SingleInstance();
            builder.RegisterType<EfAppRoleDal>().As<IAppRoleDal>().SingleInstance();
        }
    }
}