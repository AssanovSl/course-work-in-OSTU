﻿using System;

namespace Calculator
{
    public static class CalculatorFactory
    {
        public static ICalculator CreateCalculator(string name)
        {
            switch(name) 
            {
                case "plus":
                    return new Summ();
                   
                case "minus":
                    return new Sustraction();
                    
                case "multiply":
                    return new Multiplication();
                    
                case "divide":
                    return new Division();

                default:
                    throw new Exception("Неизвестная операция");
               }
        }






    }
}