using Core.DataAccess;
using Entities.Concrete;
namespace DataAccess.Abstract
{
    public interface ITestDal : IEntityRepository<Test>
    {
    }
    

}