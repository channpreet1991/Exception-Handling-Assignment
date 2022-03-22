using System;
class NegativeNumberNotAllowed: Exception   //Class which handle user defined excception
{
public NegativeNumberNotAllowed(string message): base(message)  //method for exception
{
}
}

class Test {   //drive class
 static void Main() {//main method
   try{  
       Console.WriteLine("Enter your age:");
       int age = int.Parse(Console.ReadLine());//get age from user
       if( age <= 0)
           throw new NegativeNumberNotAllowed("Negative number is not allowed");
       int currentYear = DateTime.Now.Year; //get current year
       int birthYear = currentYear - age;  //calculate birthyear
       Console.WriteLine("Year of Birth Year is " +birthYear);  //print year of birth
   }
   catch(NegativeNumberNotAllowed e)
   {
       Console.WriteLine(e);
   }
   catch (Exception e)  
   {
       Console.WriteLine("Wrong format of input");
   }
 }
}
+