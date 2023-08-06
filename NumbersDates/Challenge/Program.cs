
using System;

class Program{
    static void Main(string[] args){
       string input;

       do{
       Console.WriteLine("Which date? (or exit)");
       input=Console.ReadLine();
       
       if (input.ToLower()=="exit") {
             break;
       }
       
       if (DateTime.TryParse(input, out DateTime dt)) {
       
       
           if (DateTime.Today <dt) {
            Console.WriteLine($"That date went by {DateTime.Now.Subtract(dt).Days} days ago");
           }
           else if (DateTime.Today >dt) {
              Console.WriteLine($"That date is {DateTime.Now.Subtract(dt).Days} days away");
           }
           else {
              Console.WriteLine("That date is today!");
           }
       }
      else {
         Console.WriteLine("That doesn't seem to be a valid date");
            }

       } while (input.ToLower()!="exit");
         
       
}
}