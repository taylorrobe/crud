namespace Crud_u_like.Entities
{
    public class Address
    {
        public int Id {  get; set; }
        public string AddressLine {  get; set; }

        public static Address Create(string addressLine)
        {
            return new Address
            {
                AddressLine = addressLine.Trim()
            };
        }
    }
}
