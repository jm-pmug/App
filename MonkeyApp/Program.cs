
using MonkeyApp.Models;
using MonkeyApp.Services;

namespace MonkeyApp;

class Program
{
	static void Main()
	{
		Console.WriteLine("Bienvenue dans l'application MonkeyApp!");
		while (true)
		{
			Console.WriteLine("\nMenu:");
			Console.WriteLine("1. Lister tous les singes");
			Console.WriteLine("2. Obtenir les détails d'un singe par nom");
			Console.WriteLine("3. Obtenir un singe aléatoire");
			Console.WriteLine("4. Quitter l'application");
			Console.Write("Choisissez une option (1-4): ");

			var input = Console.ReadLine();
			switch (input)
			{
				case "1":
					ListAllMonkeys();
					break;
				case "2":
					GetMonkeyDetailsByName();
					break;
				case "3":
					GetRandomMonkey();
					break;
				case "4":
					Console.WriteLine("Au revoir!");
					return;
				default:
					Console.WriteLine("Option invalide. Veuillez réessayer.");
					break;
			}
		}
	}

	static void ListAllMonkeys()
	{
		var monkeys = MonkeyHelper.GetMonkeys();
		Console.WriteLine("\nListe des singes:");
		foreach (var monkey in monkeys)
		{
			Console.WriteLine($"- {monkey.Name} ({monkey.Location})");
		}
	}

	static void GetMonkeyDetailsByName()
	{
		Console.Write("Entrez le nom du singe: ");
		var name = Console.ReadLine();
		var monkey = MonkeyHelper.GetMonkeyByName(name ?? string.Empty);
		if (monkey is not null)
		{
			Console.WriteLine($"\nNom: {monkey.Name}\nLocalisation: {monkey.Location}\nPopulation: {monkey.Population}\nDétails: {monkey.Details}\nImage: {monkey.Image}\nLatitude: {monkey.Latitude}\nLongitude: {monkey.Longitude}");
		}
		else
		{
			Console.WriteLine("Aucun singe trouvé avec ce nom.");
		}
	}

	static void GetRandomMonkey()
	{
		var monkey = MonkeyHelper.GetRandomMonkey();
		Console.WriteLine($"\nSinge aléatoire:");
		Console.WriteLine($"Nom: {monkey.Name}\nLocalisation: {monkey.Location}\nPopulation: {monkey.Population}\nDétails: {monkey.Details}\nImage: {monkey.Image}\nLatitude: {monkey.Latitude}\nLongitude: {monkey.Longitude}");
		Console.WriteLine($"Accès à la sélection aléatoire: {MonkeyHelper.GetRandomMonkeyAccessCount()}");
	}
}
