class Solution {
    
    static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        int sum = 0;
        int max = -1;
        while (n > 0){

            if (n % 2 == 1){
                sum += 1;
            }
            else{
                sum = 0;
            }
            n = (int)(n/2);
            if (sum > max){
                max = sum;
            }
        }
        Console.WriteLine(max);
    }
}
