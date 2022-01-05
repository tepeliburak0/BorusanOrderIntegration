 using Autofac;
using Autofac.Extras.DynamicProxy;
using BorusanOrderIntegration.Business.Abstract;
using BorusanOrderIntegration.Business.Concrete;
using BorusanOrderIntegration.Core.Interceptors;
using BorusanOrderIntegration.DataAccess.Abstract;
using BorusanOrderIntegration.DataAccess.Concrete.EntityFramework;
using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Text;


namespace BorusanOrderIntegration.Business.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<OrderManager>().As<IOrderService>();
            builder.RegisterType<EfOrderDal>().As<IOrderDal>();

            builder.RegisterType<StockDetailManager>().As<IStockDetailService>();
            builder.RegisterType<EfStockDetailDal>().As<IStockDetailDal>();

            builder.RegisterType<OrderStatusManager>().As<IOrderStatusService>();
            builder.RegisterType<EfOrderStatusDal>().As<IOrderStatusDal>();

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();

        }
    }
}