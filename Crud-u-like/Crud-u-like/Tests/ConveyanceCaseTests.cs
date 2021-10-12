using NUnit.Framework;
using Crud_u_like.Tests.Creators.Service;
using Crud_u_like.Models;
using Testify;
using Crud_u_like.Enums;
using Crud_u_like.Tests.Creators.Repository;

namespace Crud_u_like.Tests
{
    [TestFixture]
    public class CreateConveyanceCaseTests
    {
        private static readonly AnonymousData AnonymousData = new AnonymousData();

        [Test]
        public void CreateConveyanceCaseTest()
        {
            var service = ConveyanceCaseServiceCreator.CreateService();

            var model = CreateConveyanceCaseModel.Create(
                (int)AnonymousData.AnyEnumValue<CaseTypeEnum>(), 
                (int)AnonymousData.AnyEnumValue<CaseStatusEnum>(), 
                AnonymousData.AnyString(), 
                AnonymousData.AnyDecimal(), 
                false);

            var caseId = service.Post(model);

            var dbCase = ConveyanceCaseRepositoryCreator.GetConveyanceCase(caseId);
            Assert.IsNotNull(dbCase);
            Assert.AreEqual(caseId, dbCase.Id);
            Assert.AreEqual(model.CaseTypeId, dbCase.CaseTypeId);
            Assert.AreEqual(model.CaseStatusId, dbCase.CaseStatusId);
            Assert.AreEqual(model.TransactionAmount, dbCase.TransactionAmount);
            Assert.AreEqual(model.AddressLine, dbCase.Address.AddressLine);
        }
    }
}
