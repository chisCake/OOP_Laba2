using System;
using System.Collections.Generic;

namespace OOP_Laba2 {
	class Types {
		public static void Menu() {
			while (true) {
				Console.Clear();
				Console.Write(
					"1) Определение переменных всех возможных примитивных типов" +
					"\n2) 5 операция неявного и явного приведения" +
					"\n3) Упаковка значимых и незначимых типов" +
					"\n4) Неявно типизированная переменная" +
					"\n5) Nullable переменная" +
					"\n6) Переменная типа var" +
					"\n0) Назад" +
					"\nВыберите пункт: "
				);
				if (!int.TryParse(Console.ReadLine(), out int opt))
					continue;
				Console.WriteLine();
				switch (opt) {
					case 1:
						AllTypes();
						break;
					case 2:
						Conversions();
						break;
					case 3:
						PackingUnpacking();
						break;
					case 4:
						VarExample();
						break;
					case 5:
						NullableExample();
						break;
					case 6:
						VarErrorExample();
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

		private static void AllTypes() {
			bool bool_false = false, bool_true = true;
			Console.WriteLine($"\tЛогический тип:\n\t\tИстина: {bool_true}\n\t\tЛожь: {bool_false}");

			char char_A = 'A', char_0 = (char)48;
			Console.WriteLine($"\tСимвольный тип:\n\t\tСимвол 'A': {char_A}\n\t\tСимвол '0': {char_0}");


			Console.WriteLine("\n\nЦелочисленный типы:");

			sbyte sbyte_min = sbyte.MinValue, sbyte_max = sbyte.MaxValue;
			Console.WriteLine($"\n\t8-битный знаковый тип sbyte:\n\t\tMin: {sbyte_min}\n\t\tMax: {sbyte_max}");
			byte byte_min = byte.MinValue, byte_max = byte.MaxValue;
			Console.WriteLine($"\n\t8-битный беззнаковый тип byte:\n\t\tMin: {byte_min}\n\t\tMax: {byte_max}");

			short short_min = short.MinValue, short_max = short.MaxValue;
			Console.WriteLine($"\n\t16-битный знаковый тип short:\n\t\tMin: {short_min}\n\t\tMax: {short_max}");
			ushort ushort_min = ushort.MinValue, ushort_max = ushort.MaxValue;
			Console.WriteLine($"\n\t16-битный беззнаковый тип ushort:\n\t\tMin: {ushort_min}\n\t\tMax: {ushort_max}");

			int int_min = int.MinValue, int_max = int.MaxValue;
			Console.WriteLine($"\n\t32-битный знаковый тип int:\n\t\tMin: {int_min}\n\t\tMax: {int_max}");
			uint uint_min = uint.MinValue, uint_max = uint.MaxValue;
			Console.WriteLine($"\n\t32-битный беззнаковый тип uint:\n\t\tMin: {uint_min}\n\t\tMax: {uint_max}");

			long long_min = long.MinValue, long_max = long.MaxValue;
			Console.WriteLine($"\n\t64-битный знаковый тип long:\n\t\tMin: {long_min}\n\t\tMax: {long_max}");
			ulong ulong_min = ulong.MinValue, ulong_max = ulong.MaxValue;
			Console.WriteLine($"\n\t64-битный беззнаковый тип ulong:\n\t\tMin: {ulong_min}\n\t\tMax: {ulong_max}");


			Console.WriteLine("\n\nЧисловые типы с плавающей точкой:");

			float float_min = float.MinValue, float_max = float.MaxValue;
			Console.WriteLine($"\n\t16-битный тип float:\n\t\tMin: {float_min}\n\t\tMax: {float_max}");
			double double_min = double.MinValue, double_max = double.MaxValue;
			Console.WriteLine($"\n\t32-битный тип double:\n\t\tMin: {double_min}\n\t\tMax: {double_max}");
			decimal decimal_min = decimal.MinValue, decimal_max = decimal.MaxValue;
			Console.WriteLine($"\n\t64-битный тип decimal:\n\t\tMin: {decimal_min}\n\t\tMax: {decimal_max}");


			Console.WriteLine("\n\nСсылочные типы:");

			object date = new DateTime(), random = new Random(), program = new Program();
			Console.WriteLine($"\n\tОбъект:\n\t\tDateTime: {date}\n\t\tRandom Class: {random}\n\t\tProgram Class: {program}");

			string string1 = "Первая строка", string2 = "Вторая строка";
			Console.WriteLine($"\n\tСтрока:\n\t\tСтрока №1: {string1}\n\t\tСтрока №2: {string2}");

			Console.WriteLine("\n\tДинамический тип:");
			dynamic dyn = 123;
			Console.WriteLine($"\t\tDynamic variable value = {dyn}, dynamic variable type = {dyn.GetType()}");
			dyn = new Program();
			Console.WriteLine($"\t\tDynamic variable value after changes = {dyn}, dynamic variable type = {dyn.GetType()}");
		}

		private static void Conversions() {
			// Неявные преобразования
			sbyte a = 127;
			short b = a;
			int c = b;
			long d = c;
			float e = d;
			Console.WriteLine($"Неявно: sbyte {a} --> short {b} --> int {c} --> long {d} --> float {e}");

			// Явные преобразования
			double f = 1707.1707;
			int g = (int)f;
			int h = Convert.ToInt32(f);
			string i = f.ToString();
			bool btrue = Convert.ToBoolean(f), bfalse = Convert.ToBoolean(0);
			string number = "123";
			int j = int.Parse(number);
			DateTime date = Convert.ToDateTime("07.09.2020 21:55");

			Console.WriteLine(
				$"Явно: double f {f} --(int)--> int g {g}" +
				$"\nЯвно: double f {f} --Convert.ToInt32()--> int h {h}" +
				$"\nЯвно: double f {f} --.ToString()--> string i {i}" +
				$"\nЯвно: double f {f} --Convert.ToBoolean()--> bool btrue {btrue}" +
				$"\nЯвно: 0 --Convert.ToBoolean()--> bool bfalse {bfalse}" +
				$"\nЯвно: string number {number} --.Parse()--> int j {j}" +
				$"\nЯвно: \"07.09.2020 21:55\" --Convert.ToDateTime()--> {date}"
			);
		}

		private static void PackingUnpacking() {
			int some_int = 2200;
			object some_object = some_int;
			Console.WriteLine($"Упаковка int в object: {some_int} --> {some_object}");
			string some_string = some_object.ToString();
			Console.WriteLine($"Распаковка object в string: {some_object} --> {some_string}");
		}

		private static void VarExample() {
			int[] numbers = { 1, 2, 3 };
			string[] strings = { "Раз", "Два", "Три" };
			bool[] bools = { false, true };
			List<Array> arrays = new List<Array> { numbers, strings, bools };

			Console.WriteLine("Пример с использованием var: перечисление разнотипных данных в одном и том же foreach");
			foreach (Array array in arrays) {
				Console.WriteLine($"Перечисление элементов массива типа {array.GetType()}");
				foreach (var item in array)
					Console.Write(item + " ");
				Console.WriteLine();
			}
		}

		private static void NullableExample() {
			int? smth = null;
			Console.WriteLine($"Переменная smth объявлена, но не инициализированна:\n\tHasValue: {smth.HasValue}");
			smth = 123;
			Console.WriteLine($"Переменной smth присвоено значение:\n\tHasValue: {smth.HasValue}\n\tValue: {smth.Value}");
		}

		private static void VarErrorExample() {
			//var smth = 123;
			//smth = 123.132;
			//smth = "123";
			Console.WriteLine(
				"Переменной типа var нельзя присвоить значение отличающегося по типу от начального, " +
				"\nт.к. переопределение типа переменной в памяти во время работы невозможно. " +
				"\nА компилятор автоматически подбирает тип переменной при компиляции, " +
				"\nосновываясь на типе результата выражения справа"
			);
		}
	}
}
