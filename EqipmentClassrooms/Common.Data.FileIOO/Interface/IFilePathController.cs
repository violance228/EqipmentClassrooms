namespace Common.Data.FileIO.Interfaces
{

    public interface IFilePathController
    {
        string BaseFileName { get; set; }
        string DirectoryName { get; set; }
        string FilePath { get; }

        string CreateFileName(string fileExt);
        void PrepareFileNameToLoad(ref string fileName, string requiredFileExt);
        void PrepareFileNameToSave(ref string fileName, string requiredFileExt);
    }
}