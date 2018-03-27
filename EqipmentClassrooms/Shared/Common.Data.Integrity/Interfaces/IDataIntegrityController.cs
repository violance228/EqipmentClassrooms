using Common.Interfaces;

namespace Common.Data.Integrity.Interfaces {
    public interface IDataIntegrityController<T> where T : IEntity {

        bool AutoEnsuringIntegrity { get; set; }
        void EnsureTotalIntegrity();
    }
}
