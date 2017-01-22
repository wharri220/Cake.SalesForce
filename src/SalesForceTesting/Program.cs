using Cake.SalesForce.Services;

namespace SalesForceTesting {
    class Program {
        static void Main() {
            var salesforceService = new SalesForceService();
            salesforceService.GetSessionId();
        }
    }
}
