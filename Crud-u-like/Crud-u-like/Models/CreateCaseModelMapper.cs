using Crud_u_like.Entities;

namespace Crud_u_like.Models
{
    public class CreateCaseModelMapper
    {
        public static ConveyanceCase Map(CreateConveyanceCaseModel model)
        {
            return ConveyanceCase.Create(model.CaseTypeId, model.CaseStatusId, model.AddressLine, model.TransactionAmount);
        }
    }
}
