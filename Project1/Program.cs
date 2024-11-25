using System;
using System.Security.Cryptography.X509Certificates;
public class Exam{
    public static void Main(){
        
        // Exam 1
    string name = "Sara";
    int age = 23;
    double favoriteNumber = 13.10D;
        
        Console.WriteLine($"Hello, My name is {name}. I am {age} years old, and my favorite number is {favoriteNumber}.");
        

        // Exam 2
        Console.WriteLine("Enter 5 numbers :");
        int [] array = new int[5];
        int user = Convert.ToInt32(Console.ReadLine());
         Console.WriteLine("i"+array[0]);
        
        //Exam3
        Console.WriteLine("Enter number :");
        int user2 = Convert.ToInt32(Console.ReadLine());
        // IsEven();
        


        //Exam 4
        Console.WriteLine ("Enter Your age :");
        int ageUser = Convert.ToInt32(Console.ReadLine());
        if (ageUser < 12){
            Console.WriteLine("You are a child");
        }
        else if (ageUser >= 13 && ageUser <= 17){
            Console.WriteLine("You are a teenager");
        }
        else if (age >= 18){
            Console.WriteLine("You are an adult");
        }
    
      // /Exam 5
        Console.WriteLine("Enter a number between 1 and 12 :");
        int number=Convert.ToInt32(Console.ReadLine());
        int month = 12;
        
        switch (month){

             case 1: 
            
                Console.WriteLine("January");
                break;
             
            case 2:
            
                Console.WriteLine("February");
                break ;
            
            case 3:
           
                Console.WriteLine("March");
                break;
            
            case 4:
           
                Console.WriteLine("April");
                 break;
            
            case 5:
            
                Console.WriteLine("May");
                break;
            
            case 6:
             
                Console.WriteLine("Jun");
                break;
            
            case 7:
             
                Console.WriteLine("Jul");
                break;
            
            case 8:
               
                Console.WriteLine("August");
                break;
            
            case 9:
             
                Console.WriteLine("Septmber");
                break;
            
            case 10:
            
                Console.WriteLine("Octubr");
                break;
            case 11:
                Console.WriteLine("Novmber");
                break;    
            
            case 12:
                Console.WriteLine("December");
                break;
            
            default:
            Console.WriteLine("Only numbers between 1 and 12");
            break;
        }
        //Exam 6

         Book  angry= new Book();
        angry.printDetails();
     
        
    }
  
    public static bool IsEven (int number){
        if(number % 2 == 0){
         Console.WriteLine("The number is even!");   

            return true;
        }
        
        else if (number % 2 == 1){
            Console.WriteLine("The number is odd!"); 
            return false;
         }
         return true;
    }
    }

  // Exam 6
    public class Book{
        public static void st(){
       
       
            string Title = "Exam";
            string Author = "Tuwaiq";
            double Price = 35000;

          PrintDetails(Title, Author, Price);
           int [] book  = new int[3];
          Console.WriteLine($"Title : {Title}, Author: {Author},Price : {Price} ");
     
       } 
    
}