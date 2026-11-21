using System.Security.Cryptography;
using System.Text;

namespace WinFormsApp4;

internal sealed class AuthService
{
    private readonly Dictionary<string, UserAccount> accounts = new(StringComparer.OrdinalIgnoreCase)
    {
        ["admin@stockpilot.com"] = new UserAccount("Admin User", "admin", HashPassword("Admin123!"))
    };

    public static AuthService Instance { get; } = new();

    private AuthService()
    {
    }

    public bool TryRegister(string name, string email, string password, out UserAccount? account, out string message)
    {
        account = null;
        email = email.Trim();

        if (string.IsNullOrWhiteSpace(name) || name.Trim().Length < 2)
        {
            message = "Please enter your full name.";
            return false;
        }

        if (!email.Contains('@') || !email.Contains('.'))
        {
            message = "Please enter a valid email address.";
            return false;
        }

        if (password.Length < 8 || !password.Any(char.IsUpper) || !password.Any(char.IsDigit))
        {
            message = "Password must be 8+ characters with a capital letter and a number.";
            return false;
        }

        if (accounts.ContainsKey(email))
        {
            message = "An account with this email already exists.";
            return false;
        }

        account = new UserAccount(name.Trim(), email, HashPassword(password));
        accounts[email] = account;
        message = "Account created successfully.";
        return true;
    }

    public bool TryLogin(string email, string password, out UserAccount? account)
    {
        account = null;
        email = email.Trim();

        if (!accounts.TryGetValue(email, out var savedAccount) || savedAccount.PasswordHash != HashPassword(password))
        {
            return false;
        }

        account = savedAccount;
        return true;
    }

    private static string HashPassword(string password)
    {
        return Convert.ToHexString(SHA256.HashData(Encoding.UTF8.GetBytes(password)));
    }
}

internal sealed record UserAccount(string Name, string Email, string PasswordHash);
