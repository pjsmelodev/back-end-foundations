using System;

class GetType {
    static void Main(string[] args) {
        string myVariable = "This fruit is an apple";
        Type dataType = myVariable.GetType();
        
        Console.WriteLine(dataType);
    }
}