

namespace DesignPatternsLibrary.Creational_5._Prototype
{
    public class ConcretePrototypeB : IPrototype<ConcretePrototypeB>
    {
        public int PropertyB { get; set; }

        public ConcretePrototypeB(int propertyB)
        {
            PropertyB = propertyB;
        }

        public ConcretePrototypeB Clone()
        {
            return new ConcretePrototypeB(PropertyB);
        }
    }
}
