using Common.Data.Interfaces;
using System;

namespace Common.Data.FileIO.Interfaces
{
    public interface IFileOperationsController
    {
        event EventHandler<EventArgs> DataLoaded;
        IEntitiesDataSet DataSet { get; }
        string FileName { get; set; }
        string DefaultFileName { get; set; }
        bool TestDataIsLoaded { get; }
        bool LoadTestData();
        void New();
        void Open();
        void Save();
        void SaveAs();
        void SaveAsText();
        void Close();
    }
}
