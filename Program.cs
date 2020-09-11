using System;
using System.Linq;

namespace OOP_Laba2 {
    class Program {
        static void Main() {
            while (true) {
                Console.Clear();
                Console.Write(
                    "1) Типы" +
                    "\n2) Строки" +
                    "\n3) Массивы" +
                    "\n4) Кортежи" +
                    "\n5) Локальная функция" +
                    "\n6) Checked/unchecked" +
                    "\n0) Выход" +
                    "\nВыберите пункт: "
                );
                if (!int.TryParse(Console.ReadLine(), out int opt))
                    continue;
                Console.WriteLine();
                switch (opt) {
                    case 1:
                        Types.Menu();
                        break;
                    case 2:
                        Strings.Menu();
                        break;
                    case 3:
                        Arrays.Menu();
                        break;
                    case 4:
                        Tuples.Menu();
                        break;
                    case 5:
                        // Ввод кол-во элементов массива
                        int amt;
                        while (true) {
                            Console.Write("Введите кол-во элементов массива: ");
                            if (!int.TryParse(Console.ReadLine(), out amt)) {
                                Console.WriteLine("Введите натуральное число");
                                continue;
                            }
                            else
                                break;
                        }
                        // Создание массива
                        int[] arr = new int[amt];
                        Console.WriteLine("Заполните массив целочисленными значениями");
                        for (var i = 0; i < amt; i++) {
                            while (true) {
                                Console.Write($"{i + 1}) ");
                                if (int.TryParse(Console.ReadLine(), out arr[i]))
                                    break;
                                else
                                    Console.WriteLine("Введите целое число");
                            }
                        }

                        Console.WriteLine("Введите строку: ");
                        string str = Console.ReadLine();

                        var (max, min, sum, letter) = LocalFunction(arr, str);

                        Console.WriteLine(
                            $"\nМаксимальный элемент массива: {max}, минимальный: {min}" +
                            $"\nСумма всех элементов: {sum}");
                        if (letter == '0')
                            Console.WriteLine("Букв в строке нет");
                        else
                            Console.WriteLine($"Первая буква строки: {letter}");
                        break;
                    case 6:
                        Console.WriteLine("Сейчас будет вызвана функция с checked");
                        Console.ReadKey();
                        Checked();

                        Console.WriteLine("\nСейчас будет вызвана функция с unchecked");
                        Console.ReadKey();
                        Unchecked();
                        break;
                    case 0:
                        Console.WriteLine("Выход...");
                        return;
                    default:
                        Console.WriteLine($"Нет такого пункта");
                        break;
                }
                Console.ReadKey();
            }

            static (int max, int min, int sum, char letter) LocalFunction(int[] arr, string str) {
                int max = arr.Max(),
                    min = arr.Min(),
                    sum = arr.Sum();

                // Поиск первой буквы в массиве
                char[] symbols = str.ToCharArray();
                char letter = '0';
                foreach (char symbol in symbols) {
                    int keyCode = (int)symbol;
                    if ((keyCode > 64 && keyCode < 91) || (keyCode > 96 && keyCode < 123) ||        // A-Z || a-z
                        (keyCode > 1039 && keyCode < 1104)) {                                       // А-я
                        letter = symbol;
                        break;
                    }
                }

                return (max, min, sum, letter);
            }

            static void Checked() {
                try {
                    checked {
                        int max = int.MaxValue;
                        Console.WriteLine($"int max + 1 = {max + 1}");
                    }
                }
                catch (Exception error) {
                    Console.WriteLine($"Возникла ошибка переполнения:\n{error}");
                }
            }

            static void Unchecked() {
                unchecked {
                    int max = int.MaxValue;
                    Console.WriteLine($"int max + 1 = {max + 1}");
                }
            }
        }
    }
}
