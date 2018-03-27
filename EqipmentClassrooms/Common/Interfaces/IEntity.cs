namespace Common.Interfaces
{
    public interface IEntity
    {// : IDataStringable
        int? Id { get; set; }
        string Key { get; }
    }
}
