using System;

namespace PracticeProblem
{  
    class LineComparisonProblem
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter x1 Value:- ");             
            int x1 = Convert.ToInt32(Console.ReadLine());       
            Console.WriteLine("Enter x2 Value:- ");              
            int x2 = Convert.ToInt32(Console.ReadLine());          
            Console.WriteLine("Enter y1 Value:- ");               
            int y1 = Convert.ToInt32(Console.ReadLine());            
            Console.WriteLine("Enter y2 Value:- ");                 
            int y2 = Convert.ToInt32(Console.ReadLine());       


            Console.WriteLine("Enter j1 Value:- ");           
            int j1 = Convert.ToInt32(Console.ReadLine());      
            Console.WriteLine("Enter j2 Value:- ");             
            int j2 = Convert.ToInt32(Console.ReadLine());         
            Console.WriteLine("Enter k1 Value:- ");                
            int k1 = Convert.ToInt32(Console.ReadLine());           
            Console.WriteLine("Enter k2 Value:- ");                 
            int k2 = Convert.ToInt32(Console.ReadLine());     

            double LengthofLine1 = Math.Sqrt((x2 - x1) ^ 2 + (y2 - y1) ^ 2);  
            double LengthofLine2 = Math.Sqrt((j2 - j1) ^ 2 + (k2 - k1) ^ 2);  
            Console.WriteLine("Length of (x, y) co-ordinates -  " + LengthofLine1);  
            Console.WriteLine("Length of (j, k) co-ordinates -  " + LengthofLine2); 

            if (LengthofLine1.Equals(LengthofLine2))            
            {
                Console.WriteLine("Two lines are equal ");
            }
            else
            {
                Console.WriteLine("Two lines are Not equal");
            }
        }
    }
}