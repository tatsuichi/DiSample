using Microsoft.Extensions.DependencyInjection;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using var serviceProvider = new ServiceCollection()
                .AddTransient<InterfaceA, ClassA>()
                .AddTransient<InterfaceB, ClassB>()
                .AddTransient<InterfaceC, ClassC>()
                .BuildServiceProvider();

            var a = serviceProvider.GetRequiredService<InterfaceA>();
            a.DoAction();

            var b = serviceProvider.GetRequiredService<InterfaceB>();
            b.DoAction();
        }
    }
}