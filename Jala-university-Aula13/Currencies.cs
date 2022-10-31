namespace Jala_university_Aula13;

internal static class Currencies
{
    public static Dictionary<string, decimal> Availables { get; set; } = new Dictionary<string, decimal>()
    {
        {"USD", 0.18M},
        {"CAD", 0.90M},
        {"EUR", 0.20M},
    };
}