using Lab.EF.Entities;
using System.Collections.Generic;
using System.Linq;


namespace Lab.EF.Logic
{
    public class CategoriesLogic : BaseLogic
    {
        public List<Categories> ObtenerTodo()
        {
            return _northwindcontext.Categories.ToList();
        }

    }
}
