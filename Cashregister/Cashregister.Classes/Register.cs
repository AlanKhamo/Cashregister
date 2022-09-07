namespace Cashregister.Classes
{
     public class Register
     {
          private int noOfItems;
          public double Total { get; private set; }

          public void AddItem(double item)
          {
               if (item > 0)
               {
                    Total += item;
                    noOfItems++;
               }
               else
               {
                    throw new ArgumentOutOfRangeException("item skal ikke være negativ ");
               }
               
          }

          public int GetNoOfItem()
          {
               return noOfItems;
          }

     }
}