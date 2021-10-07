namespace Crud_u_like.Entities
{
    public class Client
    {
        public int Id {  get; set; }
        public string Name {  get; set; }
        public string DateOfBirth {  get; set; }
        public int AddressId {  get; set; }   
        public virtual Address Address {  get; set; }
    }
}
