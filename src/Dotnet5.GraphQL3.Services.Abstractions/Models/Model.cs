namespace Dotnet5.GraphQL3.Services.Abstractions.Models
{
    public abstract record Model<TId>
        where TId : struct
    {
        public TId? Id { get; init; }
    }
}