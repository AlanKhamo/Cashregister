using System;

namespace eksampel_cs
{
     class Program
     {
          static void Main(string[] args)
          {
               ////Variables
               //string name = "Khamo";
               //int age = 24;

               //Console.WriteLine("han hedder " + name + " til efternavn");
               //Console.WriteLine("og han er " + age);
               //name = "alan";
               //Console.WriteLine(name + " er et svært navn");

               //// Data types
               //string phrase = "Giraffe Academy";
               //char grade = 'C';
               //double gpa = 3.2;
               //bool isMale = true;

               //Console.WriteLine(gpa);


               ////working with strings

               //string hej = "giraffe academy";
               //Console.WriteLine("eow\ndig" + " lad være med at spille dum".Length); // antal af bogstaver
               //Console.WriteLine("din fucking katofel".ToUpper());  // med store bogstaver

               //Console.WriteLine("din fucking katofel".Contains("woe"));
               //Console.WriteLine(hej[0]);
               //Console.WriteLine(hej.IndexOf("academy"));

               //working with numbers

               //Console.WriteLine(5 + 10);
               //Console.WriteLine(5 % 10);


               // getting user input

               //Console.Write("enter your name: ");
               //string name = Console.ReadLine();
               //Console.Write("enter your age: ");
               //string age = Console.ReadLine();
               //Console.WriteLine("hallo " + name + " your are " + age);

               // building a calcuator

               //int num = Convert.ToInt32("54");
               //Console.WriteLine(num + 6);


               // building a mad lab

               //string color, plura, celebrity;

               //Console.Write("enter a color");
               //color = Console.ReadLine();

               //Console.Write("enter a color");
               //plura = Console.ReadLine();

               //Console.Write("enter a color");
               //celebrity = Console.ReadLine();


               //Console.WriteLine("roses are" + color);
               //Console.WriteLine("violests are" + plura);
               //Console.WriteLine("roses are" + celebrity);

               //Console.ReadLine();

               // Arrays

               //int [] luckynumbers = { 3,2};


               // classes and objects

               book book1 = new book();

               book1.title = "harry potter";
               book1.suthor = "jk rowling";
               book1.pages = 400;

               Console.WriteLine(book1.suthor);

               Console.ReadLine();

          }
     }
}
