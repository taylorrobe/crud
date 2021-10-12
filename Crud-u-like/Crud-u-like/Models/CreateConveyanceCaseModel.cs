using Newtonsoft.Json;

namespace Crud_u_like.Models
{
    public class CreateConveyanceCaseModel
    {
        [JsonProperty(nameof(CaseTypeId))]
        public int CaseTypeId { get; private set; }
        
        [JsonProperty(nameof(CaseStatusId))]
        public int CaseStatusId { get; private set; }

        [JsonProperty(nameof(CaseTypeId))]
        public string AddressLine { get; set; }

        [JsonProperty(nameof(TransactionAmount))]
        public decimal TransactionAmount { get; set; }

        [JsonProperty(nameof(IsDeleted))]
        public bool IsDeleted { get; set; }

        public static CreateConveyanceCaseModel Create(int caseTypeId, int caseStatusId, string addressLine, decimal transactionAmount, bool isDeleted)
        {
            return new CreateConveyanceCaseModel
            {
                CaseTypeId = caseTypeId,
                CaseStatusId = caseStatusId,
                AddressLine = addressLine,
                TransactionAmount = transactionAmount,
                IsDeleted = isDeleted
            };
        }
    }
}
