using System.Linq.Expressions;
using TikiAPI.Data;

namespace TikiAPI.Specifications.CategorySpecification
{
    public class CategorySpecification : Specification<Category>
    {
        private readonly string _name;

        public CategorySpecification(string name) {
            _name = name;
        }
        public override Expression<Func<Category, bool>> ToExpression()
        {
            return c => c.Name == _name; 
        }
    }
}
