namespace Library.Test.Tests
{
    internal class TriangleTest
    {
        [Test]
        public void TestArea()
        {
            var triangle = new Triangle(0, 0, 3.5, 4, 5, 7.8);
            var area = triangle.Area;
            Assert.That(area, Is.EqualTo(3.65).Within(Constants.Eps));
        }

        [Test]
        public void TestIsNotRightAngled()
        {
            var triangle = new Triangle(0, 0, 3.5, 4, 5, 7.8);
            var isRightAngled = triangle.IsRightAngled;
            Assert.That(isRightAngled, Is.EqualTo(false));
        }

        [Test]
        public void TestIsRightAngled()
        {
            var triangle = new Triangle(0, 0, 3, 0, 0, 4);
            var isRightAngled = triangle.IsRightAngled;
            Assert.That(isRightAngled, Is.EqualTo(true));
        }

        [Test]
        public void TriangleWithTheseCoordinatesMustThrowException()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(2, 0, 4, 0, 6, 0));
        }
    }
}
