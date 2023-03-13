using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using Core.Utilities.Security.JWT;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;

namespace Business.DependencyResolvers.Autofac
{
    //IOC
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {

            builder.RegisterType<PersonelManager>().As<IPersonelService>().SingleInstance();
            builder.RegisterType<EfPersonelDal>().As<IPersonelDal>().SingleInstance();

            builder.RegisterType<PersonelShiftManager>().As<IPersonelShiftService>().SingleInstance();
            builder.RegisterType<EfPersonelShiftDal>().As<IPersonelShiftDal>().SingleInstance();







            builder.RegisterType<AuthManager>().As<IAuthService>();
            builder.RegisterType<JwtHelper>().As<ITokenHelper>();


            //Autofac interceptors
            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();

        }
    }
}