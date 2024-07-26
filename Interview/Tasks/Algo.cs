using Interview.Models;

namespace Interview.Tasks;

public class Algo
{
    #region Задача 1

    /// <summary>
    /// Найти индекс числа <paramref name="id"/> в отсортированном массиве <paramref name="array"/>
    /// </summary>
    /// <param name="array">Отсортированный массив, не имеющий повторений значений.</param>
    /// <param name="id">Число, которое необходимо найти в массиве.</param>
    /// <returns>Индекс числа или null, при его отсутствии.</returns>
    public static int? Algo1(int[] array, int id)
    {
        return null;
    }

    #endregion

    #region Задача 2

    /// <summary>
    /// Реализовать эффективный поиск длинных строк по их id.
    /// Список с LongStringModel среднего размера, а список с id очень большого размера.
    /// </summary>
    /// <param name="stringModels">Коллекция элементов.</param>
    /// <param name="ids">Id требуемых элементов.</param>
    /// <returns>Коллекция строк, соответствующих переданным id.</returns>
    public static IEnumerable<string> Algo2(
        IList<LongStringModel> stringModels, 
        IList<int> ids)
    {
        // int id = stringModels.First().Id;
        // string value = stringModels.First().Value;
        return [];
    }

    #endregion
}