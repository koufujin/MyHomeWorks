namespace TMS_HomeWork12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Введите логин: ");
                string login = Console.ReadLine();
                Console.Write("Введите пароль: ");
                string password = Console.ReadLine();
                Console.Write("Подтвердите пароль: ");
                string confirmPassword = Console.ReadLine();

                try
                {
                    bool isValid = Account.Validate(login, password, confirmPassword);
                    Console.WriteLine("Данные прошли проверку");
                    Console.WriteLine("Аккаунт успешно создан");
                    Console.WriteLine();
                    Account account = new Account(login, password);
                    Console.WriteLine($"Ваши данные:\nлогин {account.login}\nпароль {account.password}");
                    return;
                }
                catch (WrongLoginException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                catch (WrongPasswordException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
