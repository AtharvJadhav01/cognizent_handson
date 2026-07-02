import java.util.Scanner;

public class FinancialForecast {

    // Recursive method
    public static double forecast(double currentValue, double growthRate, int years) {

        // Base case
        if (years == 0) {
            return currentValue;
        }

        // Recursive call
        return forecast(currentValue * (1 + growthRate), growthRate, years - 1);
    }

    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        System.out.print("Enter current value: ");
        double currentValue = sc.nextDouble();

        System.out.print("Enter annual growth rate (in %): ");
        double growthRate = sc.nextDouble() / 100;

        System.out.print("Enter number of years: ");
        int years = sc.nextInt();

        double futureValue = forecast(currentValue, growthRate, years);

        System.out.printf("\nPredicted Future Value = %.2f", futureValue);

        sc.close();
    }
}