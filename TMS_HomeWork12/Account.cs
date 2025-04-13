using System.Globalization;

namespace TMS_HomeWork12;

public class Account
{
     public string login { get;  private set; }
     public string password { get;  private set; }
     public string confirmPassword { private get;  set; }

    public Account(string login, string password)
    {
        this.login = login;
        this.password = password;
    }

    public static bool Validate (string login, string password, string confirmPassword)
    {
        if (string.IsNullOrWhiteSpace(login) || login.Contains(" ") || login.Length >= 20)
        {
            throw new WrongLoginException("Логин не должен содержать пробелов и должен быть короче 20 символов.");
        }
        if (string.IsNullOrWhiteSpace(password) || password.Contains(" ") || password.Length >= 20 || !HasDigit(password) || !password.Equals(confirmPassword))
        {
            throw new WrongLoginException("Пароль не должен содержать пробелов, должен быть короче 20 символов, иметь хотя бы одну цифру и совпадать с подтверждением.");
        }
        return true;
    }

    private static bool HasDigit(string str)
    {
        foreach (char c in str)
        {
            if (char.IsDigit(c))
                return true;
        }
        return false;
    }
}
