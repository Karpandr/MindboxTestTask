namespace Library.Test.Tests
{
    public class CircleTest
    {
        [TestCase(0.1, 0.031415926)]
        [TestCase(4.5, 63.617251235)]
        public void TestArea(double radius, double expectedResult)
        {
            var circle = new Circle(0.0, 0.0, radius);
            var area = circle.Area;
            Assert.That(area, Is.EqualTo(expectedResult).Within(Constants.Eps));
        }

        [Test]
        public void NegativeRadiusMustThrowException()
        {
            Assert.Throws<ArgumentException>(() => new Circle(5, 9, -1));
        }
    }
}