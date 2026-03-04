namespace Juniper.Core.Tagging;

public readonly record struct TagId(Guid Value);

public sealed record Tag
{
    public TagId Id { get; init; }
    public string Name { get; init; } = "";
    public string? HexColor { get; init; }
    public string? Category { get; init; }
}