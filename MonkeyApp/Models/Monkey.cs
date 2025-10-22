namespace MonkeyApp.Models;

/// <summary>
/// Représente un singe avec ses informations principales.
/// </summary>
public class Monkey
{
    /// <summary>
    /// Nom du singe.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Localisation géographique du singe.
    /// </summary>
    public string Location { get; set; }

    /// <summary>
    /// Population estimée.
    /// </summary>
    public int Population { get; set; }

    /// <summary>
    /// Description ou détails sur le singe.
    /// </summary>
    public string Details { get; set; }

    /// <summary>
    /// URL de l’image du singe.
    /// </summary>
    public string Image { get; set; }

    /// <summary>
    /// Latitude de la localisation.
    /// </summary>
    public double Latitude { get; set; }

    /// <summary>
    /// Longitude de la localisation.
    /// </summary>
    public double Longitude { get; set; }
}
