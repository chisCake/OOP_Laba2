using System;
using System.Text;

namespace OOP_Laba2 {
	class Strings {
		public static void Menu() {
			while (true) {
				Console.Clear();
				Console.Write(
					"1) Объявление и сравнение" +
					"\n2) Действия со строками" +
					"\n3) Пустая null строка" +
					"\n4) Строка на основе StringBuilder" +
					"\n0) Назад" +
					"\nВыберите пункт: "
				);
				if (!int.TryParse(Console.ReadLine(), out int opt))
					continue;
				Console.WriteLine();
				switch (opt) {
					case 1:
						Compare();
						break;
					case 2:
						Actions();
						break;
					case 3:
						NullString();
						break;
					case 4:
						StringBuilderExample();
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

		private static void Compare() {
			string str1 = "Первая строка",
				   str2 = "Вторая строка",
				   str3 = "Первая строка";
			Console.WriteLine($"Сравнение str1 \"{str1}\" и str2 \"{str2}\": {str1 == str2}");
			Console.WriteLine($"Сравнение str1 \"{str1}\" и str3 \"{str3}\": {str1 == str3}");
		}

		private static void Actions() {
#pragma warning disable IDE0059 // Ненужное присваивание значения
			String str1 = new String("Строка1"), str2 = new String("Строка2"), str3 = new String("Строка3");
#pragma warning restore IDE0059 // Ненужное присваивание значения
			Console.WriteLine(
				"Объявленные переменные:" +
				$"\nstr1: {str1}" +
				$"\nstr2: {str2}" +
				$"\nstr3: {str3}"
			);

			Console.WriteLine($"\nСцепление str1 и str2 с помощью \"+\": {str1 + str2}");
			Console.WriteLine($"Сцепление str1 и str3 с помощью \".Concat()\": {string.Concat(str1, str3)}");

			string temp = str1;
			Console.WriteLine($"\nСодержимое str1 \"{str1}\" скопировано в temp \"{temp}\"");

			Console.WriteLine($"\nВыделение из str1 первой половины букв с помощью .Substring(): {str1.Substring(0, str1.Length / 2)}");

			string normalStr = "Раз,два,три";
			Console.WriteLine($"\nСтрока normalStr не разбитая на слова: {normalStr}");
			string[] words = normalStr.Split(',');
			Console.WriteLine("Полученный массив слов:");
			foreach (string word in words)
				Console.WriteLine(word);

			Console.WriteLine($"\nВставка str1 \"{str1}\" в str2 \"{str2}\": {str2.Insert(str2.Length / 2, str1)}");

			Console.WriteLine($"\nУдаление подстроки \"ока\" из str1 \"{str1}\": {str1.Remove(str1.IndexOf("ока"), 3)}");
		}

		private static void NullString() {
			string str = "abc",
				   emptyStr = "",
				   nullStr = null;
			Console.WriteLine(
				"Проверка на .IsNullOrEmpty" +
				$"\nstr \"{str}\": {string.IsNullOrEmpty(str)}" +
				$"\nemptyStr \"{emptyStr}\": {string.IsNullOrEmpty(emptyStr)}" +
				$"\nnullStr \"{nullStr}\": {string.IsNullOrEmpty(nullStr)}"
			);
		}

		private static void StringBuilderExample() {
			var sb = new StringBuilder("Sample text");
			var originalStrLength = sb.Length;
			Console.WriteLine($"Строка построенная с помощью SringBuilder: {sb}");

			sb.Append(" / another text");
			Console.WriteLine($"\nСтрока добавлена в конец: {sb}");

			sb.Insert(0, "another text / ");
			Console.WriteLine($"\nСтрока добавлена в начало: {sb}");

			sb.Remove(sb.ToString().IndexOf('/'), originalStrLength + 3);
			Console.WriteLine($"\nУдалён текст по середине: {sb}");
		}
	}
}
