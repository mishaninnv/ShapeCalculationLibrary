using ShapeCalculationLibrary;
using ShapeCalculationLibrary.Models;

namespace ShapeCalculationLibraryTest
{
    public class Tests
    {
        private ShapeManager _shapeManager;

        [SetUp]
        public void Setup()
        {
            _shapeManager = new ShapeManager();
        }

        [Test]
        public void CircleArea()
        {
            var circle = new Circle(5);
            var result = _shapeManager.GetAreaShape(circle);
            Assert.That(result, Is.EqualTo(78.54));
        }

        [Test]
        public void NegativeRadiusCircle()
        {
            Assert.Throws<ArgumentException>(() => new Circle(-1));
        }

        [Test]
        public void TriangleArea()
        {
            var triangle = new Triangle(5, 6, 8);
            var result = _shapeManager.GetAreaShape(triangle);
            Assert.That(result, Is.EqualTo(14.98));
        }

        [Test]
        public void NegativeSideTriangle()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(-1, 6, 8));
            Assert.Throws<ArgumentException>(() => new Triangle(1, -5, 8));
            Assert.Throws<ArgumentException>(() => new Triangle(7, 6, -2));
        }

        [Test]
        public void DegenerateTriangle()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(5, 5, 10));
            Assert.Throws<ArgumentException>(() => new Triangle(4, 6, 15));
        }
    }
}