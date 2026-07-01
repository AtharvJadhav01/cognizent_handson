#include <iostream>
using namespace std;

// Recursive function to calculate future value
double futureValue(double currentValue, double growthRate, int years) {
    if (years == 0)
        return currentValue;

    return futureValue(currentValue * (1 + growthRate), growthRate, years - 1);
}

int main() {
    double currentValue, growthRate;
    int years;

    cout << "Enter current value: ";
    cin >> currentValue;

    cout << "Enter annual growth rate (in %): ";
    cin >> growthRate;

    cout << "Enter number of years: ";
    cin >> years;

    double result = futureValue(currentValue, growthRate / 100, years);

    cout << "\nPredicted Future Value = " << result << endl;

    return 0;
}