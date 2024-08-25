using University_Common.Domain;

namespace University_Web.Extensions
{
    public static class ExtensionMethods
    {
        public static async Task<List<T>> GetWithDefaultAsync<T>(
           this IUnitOfWork unitOfWork,
           Func<Task<List<T>>> getListFunc,
           string errorMessage)
        {
            var list = await getListFunc();
            if (list == null || !list.Any())
            {
                throw new Exception(errorMessage);
            }
            return list;
        }
    }
}
