namespace Core.Models.Concrete
{
    public class UserOperationClaim:IModel
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int OperationClaimId { get; set; }
    }
}
