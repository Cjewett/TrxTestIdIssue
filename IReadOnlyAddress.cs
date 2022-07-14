namespace TrxTesting
{
    public interface IReadOnlyAddress
    {
        string City { get; }
        int CountryId { get; }
        string State { get; }
        string StateDisplay { get; }
        string StateFullDescription { get; }
        string Street1 { get; }
        string Street2 { get; }
        string SubCity { get; }
        string SubState { get; }
        string Zip { get; }
        string ZipNoClean { get; }
    }
}
