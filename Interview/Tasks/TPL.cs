using Interview.Models;

namespace Interview.Tasks;

public static class TPL
{
    #region Задача 1

    /// <summary>
    /// Создать оптимальный алгоритм обработки трёх задач.
    /// </summary>
    /// <param name="task1">Задача 1.</param>
    /// <param name="task2">Задача 2.</param>
    /// <param name="task3">Задача 3.</param>
    /// <returns></returns>
    public static Task Tasks1Async(Task task1, Task task2, Task task3)
    {
        return Task.CompletedTask;
    }

    #endregion

    #region Задача 2

    /// <summary>
    /// Обработать все элементы коллекции асинхронно с возможностью отмены операции обработки.
    /// </summary>
    /// <param name="items">Элементы коллекции данных для обработки.</param>
    /// <param name="processAction">Action, производящий некую обработку.</param>
    /// <param name="ct">Токен отмены.</param>
    public static async Task Tasks2Async(
        IList<DataModel> items, 
        Action<DataModel> processAction, 
        CancellationToken ct)
    {
        
    }

    #endregion

    #region Задача 3

    /// <summary>
    /// Реализовать алгоритм обработки всех элементов коллекции с отслеживанием прогресса.
    /// </summary>
    /// <param name="items">Элементы коллекции данных для обработки.</param>
    /// <param name="processFunc">Action, производящий некую обработку.</param>
    /// <param name="progress"></param>
    public static async Task Tasks3Async(
        IList<DataModel> items, 
        Func<DataModel, Task> processFunc, 
        IProgress<double> progress)
    {
        
    }

    #endregion
}