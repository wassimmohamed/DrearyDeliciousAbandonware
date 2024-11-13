// Helper/CalculatorHelper.cs
public static class CalculatorHelper
{
    public static object Add(object num1, object num2)
    {
        // Perform the addition based on the data types
        if (num1 is int && num2 is int)
        {
            return (int)num1 + (int)num2;
        }
        else if (num1 is double && num2 is double)
        {
            return (double)num1 + (double)num2;
        }
        else if (num1 is decimal && num2 is decimal)
        {
            return (decimal)num1 + (decimal)num2;
        }
        else
        {
            throw new ArgumentException("Invalid data types for addition.");
        }
    }

    public static object Subtract(object num1, object num2)
    {
        // Perform the subtraction based on the data types
        if (num1 is int && num2 is int)
        {
            return (int)num1 - (int)num2;
        }
        else if (num1 is double && num2 is double)
        {
            return (double)num1 - (double)num2;
        }
        else if (num1 is decimal && num2 is decimal)
        {
            return (decimal)num1 - (decimal)num2;
        }
        else
        {
            throw new ArgumentException("Invalid data types for subtraction.");
        }
    }

    public static object Multiply(object num1, object num2)
    {
        // Perform the multiplication based on the data types
        if (num1 is int && num2 is int)
        {
            return (int)num1 * (int)num2;
        }
        else if (num1 is double && num2 is double)
        {
            return (double)num1 * (double)num2;
        }
        else if (num1 is decimal && num2 is decimal)
        {
            return (decimal)num1 * (decimal)num2;
        }
        else
        {
            throw new ArgumentException("Invalid data types for multiplication.");
        }
    }

    public static object Divide(object num1, object num2)
    {
        // Perform the division based on the data types, handling division by zero
        if (num1 is int && num2 is int)
        {
            if ((int)num2 == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
            return (int)num1 / (int)num2;
        }
        else if (num1 is double && num2 is double)
        {
            if ((double)num2 == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
            return (double)num1 / (double)num2;
        }
        else if (num1 is decimal && num2 is decimal)
        {
            if ((decimal)num2 == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
            return (decimal)num1 / (decimal)num2;
        }
        else
        {
            throw new ArgumentException("Invalid data types for division.");
        }
    }
}