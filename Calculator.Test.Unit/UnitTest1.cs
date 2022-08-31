namespace Calculator.Test.Unit
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
               Calculator uut = new Calculator();

               Assert.That(uut.Add(2.5,3.5), Is.EqualTo(6));
          }

          [Test]
          public void subtract()
          {
               Calculator uut = new Calculator();

               Assert.That(uut.Subtract(10, 5), Is.EqualTo(5));
          }


          [Test]
          public void multiply()
          {
               Calculator uut = new Calculator();

               Assert.That(uut.Multiply(10, 5), Is.EqualTo(50));
          }

          [Test]
          public void power()
          {
               Calculator uut = new Calculator();

               Assert.That(uut.Power(10, 5), Is.EqualTo(100000));
          }

     }
}