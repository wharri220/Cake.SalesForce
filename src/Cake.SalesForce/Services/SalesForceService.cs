using Cake.SalesForce.SalesForceMetadataApi;

namespace Cake.SalesForce.Services {
    class SalesForceService {
        private readonly MetadataPortTypeClient _salesforceClient;

        public SalesForceService() {
            _salesforceClient = new MetadataPortTypeClient();
        }

        public void DeployPackage() {
            var sessionHeader = new SessionHeader();
            var debuggingHeader = new DebuggingHeader();
            var callOptions = new CallOptions();
            var zipFile = new byte[0];
            var deployOptions = new DeployOptions();
            _salesforceClient.deploy(sessionHeader, debuggingHeader, callOptions, zipFile, deployOptions);
        }
    }
}
