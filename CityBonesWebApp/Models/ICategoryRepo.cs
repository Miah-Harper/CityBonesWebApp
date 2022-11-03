using System.Collections.Generic;

namespace CityBonesWebApp.Models
{
    public interface ICategoryRepo
    {
        IEnumerable<Category> Categories { get; }
    }
}
