using Microsoft.VisualStudio.TestTools.UnitTesting;
using Figures;
using System;

namespace Figure_tests
{
    [TestClass]
    public class Figure_area_tests
    {
        [TestMethod]
        public void Circle_area_r_1()
        {
            //arrange
            Circle circle = new Circle();
            circle.r = 1;
            double expected;
            
            //act
            double actual = circle.FindArea();

            //assert
            expected = Math.PI;
            Assert.AreEqual(expected,actual);
        }

        [TestMethod]
        public void Circle_area_r_0()
        {
            //arrange
            Circle circle = new Circle();
            circle.r = 0;
            double expected;

            //act
            double actual = circle.FindArea();

            //assert
            expected = 0;
            Assert.AreEqual(expected, actual);
        }       

        [TestMethod]
        public void Triangle_area_sides_3_4_5()
        {
            //arrange
            Triangle triangle = new Triangle();
            triangle.a = 3;
            triangle.b = 4;
            triangle.c = 5;
            double expected;

            //act
            double actual = triangle.FindArea();

            //assert
            expected = 6;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Triangle_3_4_5_IsRight()
        {
            //arrange
            Triangle triangle = new Triangle();
            triangle.a = 3;
            triangle.b = 4;
            triangle.c = 5;
            bool expected;

            //act
            bool actual = triangle.IsRightTriangle();

            //assert
            expected = true;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Triangle_area_sides_1_1_2()
        {
            //arrange
            Triangle triangle = new Triangle();
            triangle.a = 1;
            triangle.b = 1;
            triangle.c = 2;
            double expected;

            //act
            double actual = triangle.FindArea();

            //assert
            expected = 0;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Triangle_11_23_15_IsRight()
        {
            //arrange
            Triangle triangle = new Triangle();
            triangle.a = 11;
            triangle.b = 23;
            triangle.c = 15;
            bool expected;

            //act
            bool actual = triangle.IsRightTriangle();

            //assert
            expected = false;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Pentagon_area()
        {
            //arrange
            Polygon polygon = new Polygon(5);
            polygon.x[0] = 3;
            polygon.x[1] = 5;
            polygon.x[2] = 12;
            polygon.x[3] = 9;
            polygon.x[4] = 5;

            polygon.y[0] = 4;
            polygon.y[1] = 11;
            polygon.y[2] = 8;
            polygon.y[3] = 5;
            polygon.y[4] = 6;
            double expected;

            //act
            double actual = polygon.FindArea();

            //assert
            expected = 30;
            Assert.AreEqual(expected,actual);
        }
    }
}
