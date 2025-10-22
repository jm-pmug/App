using System;
using System.Collections.Generic;
using System.Linq;
using MonkeyApp.Models;

namespace MonkeyApp.Services;

/// <summary>
/// Fournit des méthodes utilitaires pour gérer une collection de singes.
/// </summary>
public static class MonkeyHelper
{
    private static readonly List<Monkey> monkeys = new()
    {
        // Exemple de données, à remplacer par des données réelles ou chargées dynamiquement
        new Monkey { Name = "Baboon", Location = "Africa & Asia", Population = 10000, Details = "Baboons are African and Arabian Old World monkeys belonging to the genus Papio, part of the subfamily Cercopithecinae.", Image = "https://raw.githubusercontent.com/jamesmontemagno/app-monkeys/master/baboon.jpg", Latitude = -8.783195, Longitude = 34.508523 },
        // ... Ajoutez les autres singes ici ...
    };

    private static int randomMonkeyAccessCount = 0;

    /// <summary>
    /// Retourne la liste de tous les singes.
    /// </summary>
    public static IReadOnlyList<Monkey> GetMonkeys() => monkeys;

    /// <summary>
    /// Retourne un singe aléatoire et incrémente le compteur d'accès.
    /// </summary>
    public static Monkey GetRandomMonkey()
    {
        randomMonkeyAccessCount++;
        var random = new Random();
        return monkeys[random.Next(monkeys.Count)];
    }

    /// <summary>
    /// Trouve un singe par son nom.
    /// </summary>
    public static Monkey? GetMonkeyByName(string name)
    {
        return monkeys.FirstOrDefault(m => string.Equals(m.Name, name, StringComparison.OrdinalIgnoreCase));
    }

    /// <summary>
    /// Retourne le nombre d'accès à la méthode GetRandomMonkey.
    /// </summary>
    public static int GetRandomMonkeyAccessCount() => randomMonkeyAccessCount;
}
