using System.Security.Cryptography;
using System.Text;

namespace POS.Application.Common;

public static class Utility
{
    private static object _lock = new object();
    private static int _lastInvoiceNumber = 0;
    private static DateTime _lastInvoiceDate = DateTime.MinValue;

    public static string GenerateInvoiceNumber(string userId)
    {
        lock (_lock)
        {
            DateTime today = DateTime.Today;

            // Reset the invoice number if the date has changed
            if (_lastInvoiceDate != today)
            {
                _lastInvoiceNumber = 0;
                _lastInvoiceDate = today;
            }

            // Increment the invoice number
            _lastInvoiceNumber++;

            // Generate the invoice number
            return $"INV-{userId}-{today:yyyyMMdd}-{_lastInvoiceNumber:0000}";
        }
    }

    public static string Hash(string text)
    {

        using (SHA256 sha256 = SHA256.Create())
        {
            byte[] txt = sha256.ComputeHash(Encoding.UTF8.GetBytes(text));

            return BitConverter.ToString(txt).Replace("-", "");
        }

    }
}
