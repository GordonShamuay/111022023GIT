// Решение задач из ур-1
// Большее из двух чисел

using System;
public class Answer {
    static void CompareNumbers(int firstNumber, int secondNumber)
    {
        // Введите свое решение ниже
	if (secondNumber > firstNumber)
        {
           Console.WriteLine("Первое число: " + firstNumber + " меньше чем второе число " + secondNumber);
        }
        else
            {
            if  (secondNumber < firstNumber) 
                 Console.WriteLine("Первое число: " + firstNumber + " больше чем второе число " + secondNumber);   
            }
    {
    if (secondNumber == firstNumber)
        Console.WriteLine("Введенные числа равны: " + firstNumber);
    }
    
    }

  // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args) {
        int firstNumber, secondNumber;

        if (args.Length >= 2) {
            firstNumber = int.Parse(args[0]);
            secondNumber = int.Parse(args[1]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            firstNumber = 33;
            secondNumber = 13;
        }

        // Не удаляйте строки ниже
        CompareNumbers(firstNumber, secondNumber);
    }
}