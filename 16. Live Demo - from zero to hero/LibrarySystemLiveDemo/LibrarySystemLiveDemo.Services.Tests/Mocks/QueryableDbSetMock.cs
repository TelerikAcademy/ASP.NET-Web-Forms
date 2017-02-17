using System.Data.Entity;
using System.Linq;
using Moq;
using System.Collections.Generic;

namespace LibrarySystemLiveDemo.Services.Tests.Mocks
{
    public class QueryableDbSetMock
    {
        public static IDbSet<T> GetQueryableMockDbSet<T>(IEnumerable<T> sourceList) where T : class
        {
            return GetQueryableMockDbSetFromArray(sourceList.ToArray());
        }

        public static IDbSet<T> GetQueryableMockDbSetFromArray<T>(params T[] sourceList) where T : class
        {
            var queryable = sourceList.AsQueryable();

            var dbSet = new Mock<IDbSet<T>>();
            dbSet.As<IQueryable<T>>().Setup(m => m.Provider).Returns(queryable.Provider);
            dbSet.As<IQueryable<T>>().Setup(m => m.Expression).Returns(queryable.Expression);
            dbSet.As<IQueryable<T>>().Setup(m => m.ElementType).Returns(queryable.ElementType);
            dbSet.As<IQueryable<T>>().Setup(m => m.GetEnumerator()).Returns(queryable.GetEnumerator());

            return dbSet.Object;
        }
    }
}