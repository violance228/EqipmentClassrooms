
namespace Common.Data.Interfaces
{
    public interface IEntitiesDataSet : IEntitiesInfoAccessible
    {
        string SubjectAreaName { get; set; }

        void CreateTestData();
        void CreateMinTestData();
        void Clear();

        string ToKeysString();
        string ToKeysString(string prompt);

    }
}
