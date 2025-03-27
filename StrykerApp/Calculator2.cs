namespace StrykerApp;

public class Calculator2
{
    public double Divide(double num1, double num2)
    {
        if (num2 == 0)
        {
            throw new ArgumentException("Cannot divide by zero.");
        }
        return num1 / num2;
    }
}
