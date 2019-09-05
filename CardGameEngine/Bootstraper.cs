using Autofac;
using CardGameEngine.ViewModels;
using System.Reflection;

namespace CardGameEngine
{
    public static class Bootstraper
    {

        public static void Init()
        {
            var builder = new ContainerBuilder();

            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly()).Where(x => x.Name.EndsWith("ViewModel")).AsSelf();

            Container = builder.Build();
        }

        public static IContainer Container { get; set; }

    }
}
