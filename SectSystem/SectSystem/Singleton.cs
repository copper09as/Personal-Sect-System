public class Singleton<T> where T : class, new()
{
    private static T instance; // 静态实例，确保全局唯一
    private static readonly object lockObj = new object(); // 线程安全锁

    public static T Instance
    {
        get
        {
            if (instance == null)
            {
                lock (lockObj)
                {
                    if (instance == null)
                    {
                        instance = new T();
                    }
                }
            }
            return instance;
        }
    }
}

