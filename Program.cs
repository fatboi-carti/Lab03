using System.Text;

int number = 305419896;

System.Console.WriteLine($"Число: {number}");
System.Console.WriteLine($"В hex: 0x{number:X8}");
System.Console.WriteLine($"Little-endian: {BitConverter.IsLittleEndian}");
byte[] numberBytes = BitConverter.GetBytes(number);
System.Console.WriteLine("Байты числа:");
System.Console.WriteLine(BitConverter.ToString(numberBytes));
string text = "Hello";
System.Console.WriteLine();
System.Console.WriteLine($"Текст: {text}");
byte[] textBytes = Encoding.UTF8.GetBytes(text);
System.Console.WriteLine("Байты текста UTF-8:");
System.Console.WriteLine(BitConverter.ToString(textBytes));