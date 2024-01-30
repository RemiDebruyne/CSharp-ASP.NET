using System.Linq.Expressions;

namespace ExerciceContact.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        void Add(T entity);
        List<T> GetAll();
        List<T> GetAll(Expression<Func<T, bool>> predicate);

        // Le predicate va nous permetre de créer un filtre spécifique pour notre entité
        T Get(Expression<Func<T, bool>> predicate);
        T? GetOneById(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
