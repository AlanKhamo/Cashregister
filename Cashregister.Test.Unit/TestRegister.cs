using Cashregister.Classes;

namespace Cashregister.Test.Unit
{
     public class TestRegister
     {
          [SetUp]
          public void Setup()
          {

          }

          [Test]
          public void AddItem_OneItem_CountCorrect()
          {
               Register uut = new Register();

               uut.AddItem(12.50);
               Assert.That(uut.GetNoOfItem(), Is.EqualTo(1));
          }

          [Test]
          public void AddItem_OneItem_TotalCorrect()
          {
               Register uut = new Register();

               uut.AddItem(12.50);
               Assert.That(uut.Total, Is.EqualTo(12.50));
          }

          [Test]
          public void AddItem_TowItem_TotalCorrect()
          {
               Register uut = new Register();

               uut.AddItem(12.50);
               uut.AddItem(1.75);

               Assert.That(uut.Total, Is.EqualTo(14.25));
          }
     }
}