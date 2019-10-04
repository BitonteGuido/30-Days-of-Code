class Solution {



    static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        int mul;
        for (int i = 1; i <= 10; i++){
            mul = n * i;
            Console.WriteLine("{0} x {1} = {2}", n, i, mul);
        }
    }
}