
using Microsoft.Extensions.DependencyInjection;


namespace DesignPatternsLibrary.Creational._6._Resolver
{
    public class DoFunkyStuffResolver
    {
        private readonly IServiceProvider _serviceProvider;

        public DoFunkyStuffResolver(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public IDoFunkyStuff? GetDoFunkyStuff(string type) => type switch
        {
            "a" => _serviceProvider.GetService<DoFunkyStuffA>(),
            "b" => _serviceProvider.GetService<DoFunkyStuffB>(),
            _ => throw new ArgumentException("Invalid logger type", nameof(type)),
        };
    }
}
