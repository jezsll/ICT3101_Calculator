using System;
namespace ICT3101_Calculator
{
    public class Calculator
    {
        public Calculator() { }
        public double DoOperation(double num1, double num2, string op)
        {
            double result = double.NaN; // Default value
                                        // Use a switch statement to do the math.
            switch (op)
            {
                case "a":
                    result = Add(num1, num2);
                    break;
                case "s":
                    result = Subtract(num1, num2);
                    break;
                case "m":
                    result = Multiply(num1, num2);
                    break;
                case "d":
                    // Ask the user to enter a non-zero divisor.
                    result = Divide(num1, num2);
                    break;
                case "f":
                    result = CalculateFactorial((int)num1);
                    break;
                // Return text for an incorrect option entry.
                default:
                    break;
            }
            return result;
        }
        public double Add(double num1, double num2)
        {
            return (num1 + num2);
        }
        public double Subtract(double num1, double num2)
        {
            return (num1 - num2);
        }
        public double Multiply(double num1, double num2)
        {
            return (num1 * num2);
        }
        public double Divide(double num1, double num2)
        {
            return (num1 / num2);
        }
        public double DivideByZero(double dividend, double divisor)
        {
            if (divisor == 0)
            {
                throw new ArgumentException("Divisor cannot be zero.", nameof(divisor));
            }
            if (dividend == 0)
            {
                throw new ArgumentException("Numerator cannot be zero.", nameof(dividend));
            }

            return dividend / divisor;
        }
        public long CalculateFactorial(int n)
        {
            if (n < 0)
            {
                throw new ArgumentException("Input must be non-negative.", nameof(n));
            }

            if (n == 0)
            {
                return 1;
            }

            long result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }

            return result;
        }
        public double CalculateTriangleArea(double height, double length)
        {
            if (height < 0 || length < 0)
            {
                throw new ArgumentException("Height and base length must be non-negative.");
            }

            return 0.5 * height * length;
        }
        public double CalculateCircleArea(double radius)
        {
            if (radius < 0)
            {
                throw new ArgumentException("Radius must be non-negative.");
            }

            return Math.PI * radius * radius;
        }

        public double UnknownFunctionA(int x, int y)
        {
            if (x < 0 || y < 0)
            {
                throw new ArgumentException("Input arguments must be non-negative.");
            }

            if (x < y)
            {
                throw new ArgumentException("x must be greater than or equal to y.");
            }

            double result = CalculateFactorial(x) / CalculateFactorial(x - y);

            return result;
        }
        
        public double UnknownFunctionB(int x, int y)
        {
            if (x < 0 || y < 0 || y > x)
            {
                throw new ArgumentException();
            }

            return CalculateFactorial(x) / (CalculateFactorial(y) * CalculateFactorial(x - y));
        }
        
        public int BinaryAddition(int binary1, int binary2)
        {
            bool isBinary1 = IsBinary(Convert.ToString(binary1));
            bool isBinary2 = IsBinary(Convert.ToString(binary2));
    
            if(!isBinary1 && !isBinary2)
            {
                return (binary1 + binary2);
            }
    
            string binaryStr1 = Convert.ToString(binary1);
            string binaryStr2 = Convert.ToString(binary2);

            string combinedBinary = binaryStr1 + binaryStr2;

            int result = Convert.ToInt32(combinedBinary, 2);

            return result;
        }

        private static bool IsBinary(string input)
        {
            return input.All(c => c == '0' || c == '1');
        }
        
        public double NewDivide(double num1, double num2)
        {
            switch (num1)
            {
                case 0 when num2 == 0:
                    return 1;
                case 0:
                    return 0;
            }

            if (num2 == 0)
            {
                throw new DivideByZeroException("Division by zero is not allowed.");
            }

            return (num1 / num2);
        }

        public string CalculateMTBF(double MTTF, double MTTR)
        {
            if(MTTF < 0 || MTTR < 0)
            {
                return "Undefined";
            }
            
            return (MTTF+MTTR).ToString("F2");
        }

        public string CalculateAvailability(double MTTF, double MTTR)
        {
            if(MTTF < 0 || MTTR < 0)
            {
                return "Undefined";
            }
            double result = (MTTF / (MTTF + MTTR)) * 100;
            return result.ToString("F2") + "%";
        }
        
        // Epic story
        // Aims to empower system quality engineers by enhancing our command line calculator program for effortless quality metric calculations.
        public double CurrentFailureIntensity(double initialFailureIntensity, double experiencedFailures, double totalExpectedFailures)
        {
            double result = initialFailureIntensity * (1 - experiencedFailures / totalExpectedFailures);
            
            return result;
        }
        
        public double AverageNumberOfExpectedFailures(double initialFailureIntensity, double totalExpectedFailures, double cpuHours)
        {
            double result = totalExpectedFailures * (1 - Math.Exp(-initialFailureIntensity / totalExpectedFailures * cpuHours));

            return Math.Round(result, 2);
        }
        
        public double DefectDensity(double defects, double size)
        {
            if(defects < 0 || size < 0)
            {
                return 0;
            }
            
            return Math.Round(defects / size, 2);
        }
        
        public double ShippedSourceInstructions(double initialRelease, double currentRelease, double codeChange,
            double codeDeleted)
        {
            double result = initialRelease + currentRelease - codeDeleted - (currentRelease * (codeChange / 100));

            return Math.Round(result, 2);
        }
        
        public double LogarithmicCurrentFailureIntensity(double initialFailureIntensity, double failureIntensityDecayParameter, double expectedNumberOfFailures)
        {
            double result = initialFailureIntensity * Math.Exp(-failureIntensityDecayParameter * expectedNumberOfFailures);

            return Math.Round(result, 2);
        }
        
        public double LogarithmicAverageNumberOfExpectedFailures(double initialFailureIntensity, double failureIntensityDecayParameter, double cpuHours)
        {
            double result = 1 / failureIntensityDecayParameter *
                            Math.Log(initialFailureIntensity * failureIntensityDecayParameter * cpuHours + 1);

            return Math.Round(result, 2);
        }
        
        public interface IFileReader {
            string[] Read(string path);
        }
        
        public class FileReader : IFileReader
        {
            public string[] Read(string path)
            {
                return File.ReadAllLines(path);
            }
        }
        
        public double GenMagicNum(double input, IFileReader fileReader)
        {
            double result = 0;
            int choice = Convert.ToInt16(input);
            
            //Dependency------------------------------
            // FileReader getTheMagic = new FileReader();
            //----------------------------------------
            
            // string[] magicStrings = getTheMagic.Read("../../../MagicNumbers.txt");
            string[] magicStrings = fileReader.Read("../../../MagicNumbers.txt");
        
            if ((choice >= 0) && (choice < magicStrings.Length))
            {
                result = Convert.ToDouble(magicStrings[choice]);
            }
            result = (result > 0) ? (2 * result) : (-2 * result);
            return result;
        }
        
    }
}
