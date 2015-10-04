using System;
using BoxingWeights;


class Program
{
    static void Main(string[] args)
    {
    Program p = new Program();
        System.Console.WriteLine("Enter weight");
        int weight = Convert.ToInt32(Console.ReadLine());
        string result;
        BoxingWeightClassifier boxWghtClass = new BoxingWeightClassifier();
        result=boxWghtClass.ClassifyBoxingWeight(weight);
        Console.WriteLine(result.ToString());
        Console.ReadLine();
        
    }  
    
        }
    

    
 