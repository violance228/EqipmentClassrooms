
namespace Common.Forms.Interfaces {
    public interface IObjectStringBrowser : IInfoDialog, IFormDialog {
        void AddStringPair(string key, string value);
    }
}
