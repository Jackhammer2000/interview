using Npgsql;

namespace Interview.Tasks;

public static class Ado
{
    #region Задача 1

    /// <summary>
    /// Реализовать метод обновления UPDATE, возвращающий флаг успешности выполнения.
    /// </summary>
    /// <param name="connectionString">Строка подключения</param>
    /// <param name="updateQuery">Запрос SQL</param>
    /// <returns></returns>
    public static bool Ado1(string connectionString, string updateQuery)
    {
        return false;
    }

    #endregion
    
    #region Задача 2

    /// <summary>
    /// Реализовать метод отображения результата запроса SELECT.
    /// Вывести каждый элемент в формате: Field: [имя столбца] = '[значение]'.
    /// </summary>
    /// <param name="connectionString">Строка подключения</param>
    /// <param name="query">Запрос SQL</param>
    public static void Ado2(string connectionString, string query)
    {
    }

    #endregion
}