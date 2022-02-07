using Autofac;

namespace Hw9
{
   public class Program
    {
        public static void Main(string[] args)
        {
            DependencyInjection injection = new DependencyInjection();
            var container = injection.RegistrationDI();
            var starter = container.Resolve<Starter>();

            starter.Start();
        }
    }
}
