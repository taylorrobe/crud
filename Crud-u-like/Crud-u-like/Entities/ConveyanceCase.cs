namespace Crud_u_like.Entities
{
    public class ConveyanceCase
    {
        public int Id { get; set; }
        public int CaseTypeId { get; set; }
        public virtual CaseType CaseType { get; set; }
        public int CaseStatusId { get; set; }
        public virtual CaseStatus CaseStatus { get; set; }
        public int AddressId { get; set; }
        public virtual Address Address { get; set; }
        public decimal TransactionAmount { get; set; }
        public bool IsDeleted { get; set; }

        public static ConveyanceCase Create(
            int caseTypeId,
            int casestatusId,
            string addressLine,
            decimal transactionAmount)
        {
            return new ConveyanceCase
            {
                CaseTypeId = caseTypeId,
                CaseStatusId = casestatusId,
                Address = Address.Create(addressLine),
                TransactionAmount = transactionAmount
            };
        }
    }
}
