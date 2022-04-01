using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceBillingModel.Models
{
    public class UploadFileErrorModel
    {
        public List<BrokerClientListError> BrokerClientListErrorsList { get; set; }
        public List<SwiftBillingNumImportError> SwiftBillingNumImportErrorsList { get; set; }
        public List<StaggingQbDetailError> StaggingQbDetailErrorsList { get; set; }
        public List<StaggingNpmError> StaggingNpmErrorsList { get; set; }
        public List<SpabyacareportError> SpabyacareportErrorsList { get; set; }
        public List<PlanDocReportPriorError> PlanDocReportPriorErrorsList { get; set; }
        public List<PlanDocReportError> PlanDocReportErrorsList { get; set; }
        public List<EmployeeNavImportError> EmployeeNavImportErrorsList { get; set; }
        public List<EcExtractError> EcExtractErrorsList { get; set; }
        public List<EbExtractError> EbExtractErrorsList { get; set; }
        public List<DebitCardSummeryError> DebitCardSummeryErrorsList { get; set; }
        public List<CobraLettersError> CobraLettersErrorsList { get; set; }
        public List<ClientListError> ClientListErrorsList { get; set; }

    }
}
