using Nexus.DataModel;
using Nexus.Extensibility;

namespace Nexus.Sources
{
    public class MySource : SimpleDataSource
    {
        public override Task<CatalogRegistration[]> GetCatalogRegistrationsAsync(string path, CancellationToken cancellationToken)
        {       
            throw new NotImplementedException();
        }

        public override Task<ResourceCatalog> GetCatalogAsync(string catalogId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public override Task ReadAsync(DateTime begin, DateTime end, ReadRequest[] requests, ReadDataHandler readData, IProgress<double> progress, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}