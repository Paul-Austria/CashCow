//@BaseCode

using CashCow.Contracts;

namespace CashCow.Transfer.Models
{
	public partial class IdentityModel : TransferObject, Contracts.IIdentifiable
	{
		public int Id { get; set; }

        public void CopyProperties(IIdentifiable other)
        {
            this.Id = other.Id;
        }
    }
}
