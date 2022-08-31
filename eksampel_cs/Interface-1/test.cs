using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_1
{
     class test
     {
          static void Main()
          {
               DoHickey obj = new DoHickey();
               obj.DoNothing();
               obj.DoSomething(2);
               obj.DoSomethingElse("hallo");
          }

     }
}
