using Microsoft.Extensions.Hosting;

namespace la_mia_pizzeria_static.Models.Repositories
{
    public interface IDbPizzaRepository
    {
        List<Pizza> All();

        List<Pizza> getAllPizza();
        void Create(Pizza pizzas, List<int> SelectedTags);
        Pizza getById(int id);

        void Update(Pizza pizzas, Pizza formData, List<int>? SelectedTags);
        void Delete(Pizza pizzas);

        List<Pizza> SearchByTitle(string? title);
    }
}
