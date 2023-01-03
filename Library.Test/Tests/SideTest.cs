namespace Library.Test.Tests
{
    internal class SideTest
    {
        [TestCase(0, 0, 39.6, 72.4, 82.522239426)]
        [TestCase(-3, 21.5, 54.5, -6.7, 64.042876262)]
        public void TestLength(double startX, double startY, double endX, double endY, double expectedResult)
        {
            var side = new Side(startX, startY, endX, endY);
            var sideLength = side.Length;
            Assert.That(sideLength, Is.EqualTo(expectedResult).Within(Constants.Eps));
        }
    }
}
