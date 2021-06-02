using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, HospitalAutomationContext>, IUserDal
    {
        public List<OperationClaim> GetClaims(User user)
        {
            using (var context = new HospitalAutomationContext())
            {
                var result = from oc in context.OperationClaims
                             join uoc in context.UserOperationClaims
                             on oc.Id equals uoc.OperationClaimId
                             where uoc.UserId == user.Id
                             select new OperationClaim { Id = oc.Id, Name = oc.Name };
                    
                    
                   /* 
                    * context.UserOperationClaims.Include(x => x.OperationClaim)
                    .Where(x => x.UserId == user.Id)
                    .Select(x => new OperationClaim { Id = x.OperationClaim.Id, Name = x.OperationClaim.Name }).ToList();
                   */

                return result.ToList();
            }
        }
    }
}
