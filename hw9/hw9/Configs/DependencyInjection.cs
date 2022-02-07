using Autofac;

namespace Hw9
{
    public class DependencyInjection
    {
        public IContainer RegistrationDI()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<FilterService>().As<IFilterService>();
            builder.RegisterType<CountService>().As<ICountService>();
            builder.RegisterType<SortServices>().As<ISortService>();
            builder.RegisterType<NotificationService>().As<INotificationService>();
            builder.RegisterType<GetAllInstruments>().As<IGetInstruments>();

            builder.RegisterType<Starter>();

            var container = builder.Build();

            return container;
        }
    }
}
