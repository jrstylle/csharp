namespace CalculateDouble
{
    class CalculateDouble: ICalculateDouble
    {
        public double Add(double number1, double number2) => number1 + number2;
        public double Subtract(double number1, double number2) => number1 - number2;
        public double Multiply(double number1, double number2) => number1 * number2;
        public double Divide(double number1, double number2) => number1 / number2;
        public double Modulus(double number1, double number2) => number1 % number2;
    }
}
