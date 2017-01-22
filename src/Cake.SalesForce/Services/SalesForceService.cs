using System;
using System.IO;
using System.Net;
using Cake.SalesForce.SalesforcePartnerApi;
using Cake.SalesForce.SalesForceMetadataApi;
using PartnerApi = Cake.SalesForce.SalesforcePartnerApi;
using MetadataApi = Cake.SalesForce.SalesForceMetadataApi;

namespace Cake.SalesForce.Services {
    public class SalesForceService {
        private readonly MetadataPortTypeClient _salesforceClient;

        public SalesForceService() {
            _salesforceClient = new MetadataPortTypeClient();
        }

        public void GetSessionId() {
            //var partnerApiClient = new SoapClient();
            //var loginResult = partnerApiClient.login(new LoginScopeHeader(), new PartnerApi.CallOptions(), "wharris@petsafe.net", "Charli$@&201604!utzUoAKsUVUtmpM6OOjEBHgcA");
            using (var client = new WebClient()) {
                // read the raw SOAP request message from a file=
                var data = File.ReadAllText("C:/Users/westley/Repos/Cake.SalesForce/src/Cake.SalesForce/SoapRequests/salesforce_soap_login.xml");
                // the Content-Type needs to be set to XML
                client.Headers.Add("Content-Type", "text/xml");
                // The SOAPAction header indicates which method you would like to invoke
                // and could be seen in the WSDL: <soap:operation soapAction="..." /> element
                client.Headers.Add("SOAPAction", "''");
                var response = client.UploadString("https://login.salesforce.com/services/Soap/c/38.0", data);
            }
        }
    }
}
