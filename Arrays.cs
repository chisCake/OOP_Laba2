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
				if (!int.TryParse(Console.ReadLine(), out int opt))
					continue;
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
			// Генерация размеров матрицы
			var random = new Random();
			int x = random.Next(1, 10),
				y = random.Next(1, 10);

			// Создание матрицыы
			var matrix = new List<List<int>>();
			for (var i = 0; i < y; i++) {
				var line = new List<int>();
				matrix.Add(line);
				for (var j = 0; j < x; j++) {
					int num = random.Next(0, 1000);
					matrix[i].Add(num);
				}
			}

			// Вывод матрицы
			Console.WriteLine($"Целочисленный массив размером {y}*{x} сгенерирован");
			for (var line = 0; line < y; line++) {
				for (var column = 0; column < x; column++)
					Console.Write($"{matrix[line][column],6}");
				Console.WriteLine();
			}
		}

		private static void StringsArray() {
			string[] arr = { "Раз", "Два", "Три", "Четыре", "Пять" };
			Console.WriteLine($"Массив строк arr ({arr.Length}):");
			foreach (string item in arr)
				Console.WriteLine(item);

			bool pass = false;
			int pos = 0;
			while (!pass) {
				Console.Write($"Введите позицию элемента для изменения [1; {arr.Length}]: ");
				pos = Convert.ToInt32(Console.ReadLine());
				if (pos > 0 && pos < 6)
					pass = true;
			}
			Console.Write("Введите строку: ");
			string userStr = Console.ReadLine();

			arr[pos - 1] = userStr;
			Console.WriteLine($"Изменённый массив строк arr ({arr.Length}):");
			foreach (string item in arr)
				Console.WriteLine(item);
		}

		private static void StairStepArray() {
			var matrix = new List<List<int>>();
			Console.WriteLine("Заполните матрицу:");
			for (int i = 0; i < 3; i++) {
				var line = new List<int>();
				matrix.Add(line);
				for (int j = 0, counter = 1; j < 2 + i; j++, counter++) {
					Console.WriteLine($"{i + 1}.{counter}) Введите число: ");
					int num = Convert.ToInt32(Console.ReadLine());
					matrix[i].Add(num);
				}
			}

			Console.WriteLine("Полученный массив:");
			foreach (List<int> line in matrix) {
				foreach (int item in line) {
					Console.Write($"{item,6}");
				}
				Console.WriteLine();
			}
		}

		private static void ImplicitlyTypedArrays() {
			var arr1 = new[] { 123, 234, 345 };
			var arr2 = new[] { "Один", "Два", "Три" };
			Console.WriteLine($"Массив с числами (тип массива: {arr1.GetType()})");
			foreach (var item in arr1)
				Console.WriteLine(item);
			Console.WriteLine($"Массив со строками (тип массива: {arr2.GetType()})");
			foreach (var item in arr2)
				Console.WriteLine(item);
		}
	}
}
