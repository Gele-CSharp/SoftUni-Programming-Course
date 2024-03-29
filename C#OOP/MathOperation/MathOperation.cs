﻿namespace Operation
{
    public class MathOperation : IAdd
    {
        public int Add(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }

        public double Add(double firstNumber, double secondNumber, double thirdNumber)
        {
            return firstNumber + secondNumber + thirdNumber;
        }

        public decimal Add(decimal firstNumber, decimal secondNumber, decimal thirdNumber)
        {
            return firstNumber + secondNumber + thirdNumber;
        }
    }
}
