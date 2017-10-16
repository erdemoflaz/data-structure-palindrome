using System;
using System.Collections.Generic;

namespace Palindrome
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			// Erdem OFLAZ - Palindrom

			Stack<string> stack = new Stack<string>();
			Queue<string> queue = new Queue<string>();

			Boolean flag = false;
			Console.WriteLine("Lütfen bir metin giriniz :");
			string key = Console.ReadLine();

			// Girilen metnin WhiteSpace ve Noktalama İşaretlerinden temizlenmesi işlemini yapıyorum
			key = key.Replace(" ", "")
				   .Replace("!", "")
				   .Replace(":", "")
				   .Replace(";", "")
				   .Replace("-", "")
				   .Replace("_", "")
				   .Replace("/", "")
				   .Replace(",", "")
				   .Replace("*", "")
				   .Replace("?", "")
				   .Replace("'", "")
				   .Replace(".", "")
				   .Replace('"', ' ')
				   .Replace("...", "")
				   .ToString()
				   .ToLower();


			for (int i = 0; i < key.Length; i++)
			{
				// Girilen metnin karakterlerini stack ve queue'ya  gönderiyorum
				stack.Push(key[i].ToString());
				queue.Enqueue(key[i].ToString());

			}

			// Girilen metnin uzunluğuna göre pop işlemi sayesinde stack ve queue içerisindeki
			// değerlerin karşılaştırılma işlemi için döngümü başlatıyorum
			for (int j = 0; j < key.Length; j++)
			{
				if (stack.Pop() != queue.Dequeue())
					flag = true;

			}

			if (flag)
				Console.WriteLine("palindrom değil");
			else
				Console.WriteLine("palindrom");

		}
	}
}
