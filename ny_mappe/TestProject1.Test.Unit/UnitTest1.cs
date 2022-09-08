using CalculatorClass;

namespace TestProject1.Test.Unit
{
     public class Tests
     {
          [SetUp]
          public void Setup()
          {

          }

          [Test]
          public void add()
          {
               Class1 uut = new Class1();

               Assert.That(uut.Add(2.5, 3.5), Is.EqualTo(6));
          }

          [Test]
          public void subtract()
          {
               Class1 uut = new Class1();

               Assert.That(uut.Subtract(10, 5), Is.EqualTo(5));
          }


          [Test]
          public void multiply()
          {
               Class1 uut = new Class1();

               Assert.That(uut.Multiply(10, 5), Is.EqualTo(50));
          }

          [Test]
          public void power()
          {
               Class1 uut = new Class1();

               Assert.That(uut.Power(10, 5), Is.EqualTo(100000));
          }

          [Test]
          public void add2()
          {
               Class1 uut = new Class1();

               Assert.That(uut.Add(3, 5), Is.EqualTo(8));
          }
     }
}