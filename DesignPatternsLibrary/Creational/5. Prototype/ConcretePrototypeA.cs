using DesignPatternsLibrary.Creational_5._Prototype;

namespace DesignPatternsLibrary.Creational._5._Prototype
{
    public class ConcretePrototypeA : IPrototype<ConcretePrototypeA>
    {
        public string PropertyA { get; set; }

        public ConcretePrototypeA(string propertyA)
        {
            PropertyA = propertyA;
        }

        public ConcretePrototypeA Clone()
        {
            return new ConcretePrototypeA(PropertyA);
        }
    }
}
