using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceBillingModel.Models
{
    public class UploadFileErrorModel
    {
        public List<BrokerClientListError> BrokerClientListErrors { get; set; }
        public List<SwiftBillingNumImportError> SwiftBillingNumImportErrors { get; set; }
        public List<StaggingQbDetailError> StaggingQbDetailErrors { get; set; }
        public List<StaggingNpmError> StaggingNpmErrors { get; set; }
        public List<SpabyacareportError> SpabyacareportErrors { get; set; }
        public List<PlanDocReportPriorError> PlanDocReportPriorErrors { get; set; }
        public List<PlanDocReportError> PlanDocReportErrors { get; set; }
        public List<EmployeeNavImportError> EmployeeNavImportErrors { get; set; }
        public List<EcExtractError> EcExtractErrors { get; set; }
        public List<EbExtractError> EbExtractErrors { get; set; }
        public List<DebitCardSummeryError> DebitCardSummeryErrors { get; set; }
        public List<CobraLettersError> CobraLettersErrors { get; set; }
        public List<ClientListError> ClientListErrors { get; set; }

    }
}
