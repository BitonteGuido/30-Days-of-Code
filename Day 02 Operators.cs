class Solution {

    // Complete the solve function below.
    static void solve(double meal_cost, int tip_percent, int tax_percent) {
        double tip = 0;
        double tax = 0;
        double total_cost = 0;

        tip = meal_cost * tip_percent/100;
        tax = meal_cost * tax_percent/100;
        total_cost = Math.Round(meal_cost + tip + tax);
        Console.WriteLine(total_cost);
    }

    static void Main(string[] args) {
        double meal_cost = Convert.ToDouble(Console.ReadLine());

        int tip_percent = Convert.ToInt32(Console.ReadLine());

        int tax_percent = Convert.ToInt32(Console.ReadLine());

        solve(meal_cost, tip_percent, tax_percent);
        
    }
}
