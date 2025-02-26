using NUnit.Framework;
using TriangleSolver;

namespace TriangleTests
{
    [TestFixture]
    public class TriangleTests
    {
        // 1. **Equilateral Triangle (1 test)**
        [Test]
        public void EquilateralTriangle_AllSidesEqual_ReturnsEquilateral()
        {
            // Arrange
            int sideA = 5, sideB = 5, sideC = 5;

            // Act
            var result = Triangle.AnalyzeTriangle(sideA, sideB, sideC);

            // Assert
            Assert.AreEqual("Equilateral triangle", result);
        }

        // 2. **Isosceles Triangle (3 tests)**

        [Test]
        public void IsoscelesTriangle_TwoSidesEqual_ReturnsIsosceles()
        {
            // Arrange
            int sideA = 5, sideB = 5, sideC = 8;

            // Act
            var result = Triangle.AnalyzeTriangle(sideA, sideB, sideC);

            // Assert
            Assert.AreEqual("Isosceles triangle", result);
        }

        [Test]
        public void IsoscelesTriangle_AnotherCombination_ReturnsIsosceles()
        {
            // Arrange
            int sideA = 7, sideB = 7, sideC = 10;

            // Act
            var result = Triangle.AnalyzeTriangle(sideA, sideB, sideC);

            // Assert
            Assert.AreEqual("Isosceles triangle", result);
        }

        [Test]
        public void IsoscelesTriangle_DifferentEqualSides_ReturnsIsosceles()
        {
            // Arrange
            int sideA = 4, sideB = 7, sideC = 7;

            // Act
            var result = Triangle.AnalyzeTriangle(sideA, sideB, sideC);

            // Assert
            Assert.AreEqual("Isosceles triangle", result);
        }

        // 3. **Scalene Triangle (5 tests)**

        [Test]
        public void ScaleneTriangle_AllSidesDifferent_ReturnsScalene()
        {
            // Arrange
            int sideA = 4, sideB = 5, sideC = 6;

            // Act
            var result = Triangle.AnalyzeTriangle(sideA, sideB, sideC);

            // Assert
            Assert.AreEqual("Scalene triangle", result);
        }

        [Test]
        public void ScaleneTriangle_PythagoreanTriple_ReturnsScalene()
        {
            // Arrange
            int sideA = 3, sideB = 4, sideC = 5;

            // Act
            var result = Triangle.AnalyzeTriangle(sideA, sideB, sideC);

            // Assert
            Assert.AreEqual("Scalene triangle", result);
        }

        [Test]
        public void ScaleneTriangle_LargeSides_ReturnsScalene()
        {
            // Arrange
            int sideA = 100, sideB = 150, sideC = 200; // Updated to valid side lengths

            // Act
            var result = Triangle.AnalyzeTriangle(sideA, sideB, sideC);

            // Assert
            Assert.AreEqual("Scalene triangle", result);
        }
        [Test]
        public void ScaleneTriangle_ValidButNonRightTriangle_ReturnsScalene()
        {
            // Arrange
            int sideA = 6, sideB = 7, sideC = 8;

            // Act
            var result = Triangle.AnalyzeTriangle(sideA, sideB, sideC);

            // Assert
            Assert.AreEqual("Scalene triangle", result);
        }

        [Test]
        public void ScaleneTriangle_AnotherValidCombination_ReturnsScalene()
        {
            // Arrange
            int sideA = 9, sideB = 10, sideC = 11;

            // Act
            var result = Triangle.AnalyzeTriangle(sideA, sideB, sideC);

            // Assert
            Assert.AreEqual("Scalene triangle", result);
        }

        // 4. **Zero Length (3 tests)**

        [Test]
        public void ZeroLengthSide_ReturnsInvalid()
        {
            // Arrange
            int sideA = 0, sideB = 5, sideC = 5;

            // Act
            var result = Triangle.AnalyzeTriangle(sideA, sideB, sideC);

            // Assert
            Assert.AreEqual("Invalid Triangle - a zero has been detected", result);
        }

        [Test]
        public void ZeroLengthSide_AnotherCombination_ReturnsInvalid()
        {
            // Arrange
            int sideA = 5, sideB = 0, sideC = 5;

            // Act
            var result = Triangle.AnalyzeTriangle(sideA, sideB, sideC);

            // Assert
            Assert.AreEqual("Invalid Triangle - a zero has been detected", result);
        }

        [Test]
        public void ZeroLengthSide_ThirdCombination_ReturnsInvalid()
        {
            // Arrange
            int sideA = 5, sideB = 5, sideC = 0;

            // Act
            var result = Triangle.AnalyzeTriangle(sideA, sideB, sideC);

            // Assert
            Assert.AreEqual("Invalid Triangle - a zero has been detected", result);
        }

        // 5. **Invalid Triangle (3 tests)**

        [Test]
        public void InvalidTriangle_SumOfTwoSidesLessThanThird_ReturnsInvalid()
        {
            // Arrange
            int sideA = 1, sideB = 2, sideC = 10;

            // Act
            var result = Triangle.AnalyzeTriangle(sideA, sideB, sideC);

            // Assert
            Assert.AreEqual("INVALID!!", result);
        }

        [Test]
        public void InvalidTriangle_SumOfTwoSidesEqualToThird_ReturnsInvalid()
        {
            // Arrange
            int sideA = 5, sideB = 5, sideC = 10;

            // Act
            var result = Triangle.AnalyzeTriangle(sideA, sideB, sideC);

            // Assert
            Assert.AreEqual("INVALID!!", result);
        }

        [Test]
        public void InvalidTriangle_SumOfTwoSidesGreaterThanThird_ReturnsInvalid()
        {
            // Arrange
            int sideA = 1, sideB = 2, sideC = 4;

            // Act
            var result = Triangle.AnalyzeTriangle(sideA, sideB, sideC);

            // Assert
            Assert.AreEqual("INVALID!!", result);
        }
    }
}