namespace TMS_HomeWork4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Шифр Цезаря");
            Console.WriteLine("Нажмите 1 если хотите зашифровать \nНажмите 2 если хотите расшифровать ");
            int choose = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите текст: ");
            string input = Console.ReadLine();
            char[] newText = new char[input.Length];
            Console.WriteLine("Введите ключ шифрования: ");
            int secretKey = Convert.ToInt32(Console.ReadLine());
            string alphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя" + "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
            if (choose == 1)
            {
                for (int i = 0; i < input.Length; i++)
                {
                    char charInput = input[i];
                    int index = alphabet.IndexOf(charInput);
                    if (index != -1)
                    {
                        int newIndex = (index + secretKey) % alphabet.Length;
                        newText[i] = alphabet[newIndex];
                    }
                    else
                    {
                        newText[i] = charInput;
                    }
                }
                string finalText = new string(newText);
                Console.WriteLine(finalText);
            }
            else if (choose == 2)
            {
                for (int i = 0; i < input.Length; i++)
                {
                    char charInput = input[i];
                    int index = alphabet.IndexOf(charInput);
                    if (index != -1)
                    {
                        int newIndex = (index - secretKey) % alphabet.Length;
                        if (newIndex < 0) 
                        {
                            newIndex += alphabet.Length;
                        }
                        newText[i] = alphabet[newIndex];
                    }
                    else
                    {
                        newText[i] = charInput;
                    }
                }
                string finalText = new string(newText);
                Console.WriteLine(finalText);
            }
        }

    }
}

