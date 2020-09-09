using System;
using System.Collections.Generic;

namespace OOP_Laba2 {
    class Arrays {
        public static void Menu() {
            while (true) {
                Console.Clear();
                Console.Write(
                "1) Матрица" +
                "\n2) Массив строк" +
                "\n3) Ступенчатый массив" +
                "\n4) Неявно типизированная переменные для хранения массива и строки" +
                "\n0) Назад" +
                "\nВыберите пункт: "
                );
                if (!int.TryParse(Console.ReadLine(), out int opt)) continue;
                Console.WriteLine();
                switch (opt) {
                    case 1:
                        Matrix();
                        break;
                    case 2:
                        StringsArray();
                        break;
                    case 3:
                        StairStepArray();
                        break;
                    case 4:
                        ImplicitlyTypedArrays();
                        break;
                    case 0:
                        Console.WriteLine("Назад...");
                        return;
                    default:
                        Console.WriteLine($"Нет такого пункта");
                        break;
                }
                Console.ReadKey();
            }
        }

        private static void Matrix() {
            Random random = new Random();
            int x = random.Next(1, 10), y = random.Next(1, 10);
            List<List<int>> matrix = new List<List<int>>();
            for (int i = 0; i < y; i++) {
                List<int> line = new List<int>();
                matrix.Add(line);
                for (int j = 0; j < x; j++) {
                    matrix[i].Add(random.Next(0, 1000));
                }
            }
            Console.WriteLine($"Целочисленный массив размером {y}*{x} сгенерирован");
            for (int line = 0; line < y; line++) {
                for (int column = 0; column < x; column++)
                    Console.Write(string.Format("{0,6}", matrix[line][column]));
                Console.WriteLine();
            }
        }

        private static void StringsArray() {
            string[] arr = { "Раз", "Два", "Три", "Четыре", "Пять" };
            Console.WriteLine($"Массив строк arr ({arr.Length}):");
            foreach (var item in arr) Console.WriteLine(item);

            bool pass = false;
            int pos = 0;
            while (!pass) {
                Console.Write($"Введите позицию элемента для изменения [1; {arr.Length}]: ");
                pos = Convert.ToInt32(Console.ReadLine());
                if (pos > 0 && pos < 6) pass = true;
            }
            Console.Write("Введите строку: ");
            string userStr = Console.ReadLine();

            arr[pos - 1] = userStr;
            Console.WriteLine($"Изменённый массив строк arr ({arr.Length}):");
            foreach (var item in arr) Console.WriteLine(item);
        }

        private static void StairStepArray() {
            List<List<int>> arr = new List<List<int>>();
            int maxLength = 0;
            Console.WriteLine("Заполните матрицу:");
            for (int i = 0; i < 3; i++) {
                arr.Add(new List<int>());
                for (int j = 0, counter = 1; j < 2 + i; j++, counter++) {
                    Console.WriteLine($"{i + 1}.{counter}) Введите число: ");
                    arr[i].Add(Convert.ToInt32(Console.ReadLine()));
                    if (arr[i][j] > maxLength) maxLength = arr[i][j];
                }
            }

            Console.WriteLine("Полученный массив:");
            foreach (var line in arr) {
                foreach (var item in line) {
                    Console.Write("{0, 6}", item);                  //${item, 6}, .ToString().PadLeft(6)
                }
                Console.WriteLine();
            }
        }

        private static void ImplicitlyTypedArrays() {
            var arr1 = new[] { 123, 234, 345 };
            var arr2 = new[] { "Один", "Два", "Три" };
            Console.WriteLine($"Массив с числами (тип: {arr1.GetType()})");
            foreach (var item in arr1) Console.WriteLine(item);
            Console.WriteLine($"Массив со строками (тип: {arr2.GetType()})");
            foreach (var item in arr2) Console.WriteLine(item);
        }
    }
}
