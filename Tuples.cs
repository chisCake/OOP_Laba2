using System;

namespace OOP_Laba2 {
	class Tuples {
		public static void Menu() {
			while (true) {
				Console.Clear();
				Console.Write(
					"1) Создание кортежа, вывод" +
					"\n2) Распаковка кортежа" +
					"\n3) Сравнение кортежей" +
					"\n0) Назад" +
					"\nВыберите пункт: "
				);
				if (!int.TryParse(Console.ReadLine(), out int opt))
					continue;
				Console.WriteLine();
				switch (opt) {
					case 1:
						CreatingAndPrinting();
						break;
					case 2:
						Unpacking();
						break;
					case 3:
						Comparing();
						break;
					case 4:
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

		private static void CreatingAndPrinting() {
			(int, string, char, string, ulong) tuple = (10, "Строка1", 'A', "Строка2", ulong.MaxValue);
			object[] arr = { tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5 };
			Console.WriteLine(
				"Кортеж полученный с помощью использования типов: " +
				$"\nТип: {tuple.Item1.GetType()}, значение: {tuple.Item1}" +
				$"\nТип: {tuple.Item2.GetType()}, значение: {tuple.Item2}" +
				$"\nТип: {tuple.Item3.GetType()}, значение: {tuple.Item3}" +
				$"\nТип: {tuple.Item4.GetType()}, значение: {tuple.Item4}" +
				$"\nТип: {tuple.Item5.GetType()}, значение: {tuple.Item5}"
			);

			while (true) {
				Console.Write("\nВыберите элемент кортежа для вывода [1; 5] (0 - продолжить): ");
				if (!int.TryParse(Console.ReadLine(), out int choice))
					continue;
				if (choice == 0)
					break;
				if (choice > 0 && choice <= arr.Length)
					Console.WriteLine($"Выбранный элемент: {arr[choice - 1]}, его тип: {arr[choice - 1].GetType()}");
			}

		}

		private static void Unpacking() {
			(string, int, double) tuple1 = ("Один", 2, 3.3);
			(string stringItem, int intItem, var doubleItem) = tuple1;
			Console.WriteLine(
				"Кортеж распакован в переменные с использованием нескольких типов/var:" +
				$"\nПеременная intItem, тип: {intItem.GetType()}, значение: {intItem}" +
				$"\nПеременная doubleItem, тип: {doubleItem.GetType()}, значение: {doubleItem}" +
				$"\nПеременная stringItem, тип: {stringItem.GetType()}, значение: {stringItem}"
			);

			var tuple2 = ("Четыре", 5, 6.6);
			var (one, two, three) = tuple2;
			Console.WriteLine(
				"\nКортеж распакован в переменные с использованием var:" +
				$"\nПеременная one, тип: {one.GetType()}, значение: {one}" +
				$"\nПеременная two, тип: {two.GetType()}, значение: {two}" +
				$"\nПеременная three, тип: {three.GetType()}, значение: {three}"
			);

			var (item1, _, item3) = tuple2;
			Console.WriteLine(
				"\nРаспаковка второго кортежа, но с использованием \"_\" на втором элементе" +
				$"\nПеременная item1, тип: {item1.GetType()}, значение: {item1}" +
				"\nВторая переменная кортежа не была распакована" +
				$"\nПеременная item3, тип: {item3.GetType()}, значение: {item3}"
			);
		}

		private static void Comparing() {
			var tuple1 = (1, 2, 3);
			var tuple2 = (3, 2, 1);
			var tuple3 = (1, 2, 3);

			Console.WriteLine(
				"Используемые кортежи:" +
				"\ntuple1: 1, 2, 3" +
				"\ntuple2: 3, 2, 1" +
				"\ntuple3: 1, 2, 3"
			);

			Console.WriteLine(
				$"\ntuple1 и tuple2: {tuple1.CompareTo(tuple2)}" +
				$"\ntuple1 и tuple3: {tuple1.CompareTo(tuple3)}" +
				"\n(-1 = False, 0 = True)"
			);
		}
	}
}