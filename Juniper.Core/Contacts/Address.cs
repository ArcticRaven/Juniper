namespace Juniper.Core.Contacts;

public readonly record struct Address
{
    public string? Line1 { get; init; }
    public string? Line2 { get; init; }

    public string? Locality { get; init; }      // city/town (Perth)
    public string? Region { get; init; }        // state/province (WA)
    public string? PostalCode { get; init; }

    public string? CountryCode { get; init; }   // "US" format

    // Optional exact formatting
    public string? Formatted { get; init; }
}