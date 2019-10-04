class Solution {
    static void Main(String[] args) {
        int i = 4;
        double d = 4.0;
        string s = "HackerRank ";
        int i1;
        double d1;
        string s1;
        // Declare second integer, double, and String variables.
        
        // Read and save an integer, double, and String to your variables.
        i1 = int.Parse(Console.ReadLine());
        d1 = double.Parse(Console.ReadLine());
        s1 = Console.ReadLine();
        // Print the sum of both integer variables on a new line.
        Console.WriteLine("{0}", i1+i);
        
        // Print the sum of the double variables on a new line.
        Console.WriteLine("{0:0.0}", d1+d);
        
        // Concatenate and print the String variables on a new line
        Console.WriteLine(s+s1);
        // The 's' variable above should be printed first.
