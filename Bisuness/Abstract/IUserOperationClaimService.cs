using Core.Entities.Concrete;
using Core.Utilities.Result.Abstract;

namespace Business.Abstract
{
    public interface IUserOperationClaimService
    {
        IResult Add(UserOperationClaim userOperationClaim);
    }
}
