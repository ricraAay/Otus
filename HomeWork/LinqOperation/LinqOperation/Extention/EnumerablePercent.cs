namespace Otus.HomeWork.LinqOperation
{
    public static class EnumerablePercent
    {
        /// <summary>
        /// Метод возвращающий заданное количество процентов от выборки с округлением количества элементов в большую сторону
        /// </summary>
        public static IEnumerable<TSource> Top<TSource>(this IEnumerable<TSource> collection, int percent)
        {
            if (percent < 1 || percent > 100) 
                throw new ArgumentException("percent");

            return collection.OrderByDescending(n => n).Take((int)Math.Round((double)collection.Count() / 100 * percent));
        }

        /// <summary>
        /// Метод возвращающий заданное количество процентов от выборки с округлением количества элементов в большую сторону
        /// </summary>
        public static IEnumerable<TSource> Top<TSource, TResult>(this IEnumerable<TSource> collection, int percent, Func<TSource, TResult> keySelector)
        {
            if (percent < 1 || percent > 100)
                throw new ArgumentException("percent");

            return collection.OrderByDescending(keySelector).Take((int)Math.Round((double)collection.Count() / 100 * percent));
        }
    }
}
