class Solution {

    static void Main(String[] args) {
        string S = Console.ReadLine();

        try 
        {
            int num = int.Parse(S);
            Console.WriteLine(S);
        }
        catch(Exception)
        {
            Console.WriteLine("Bad String");
        }
    }
}