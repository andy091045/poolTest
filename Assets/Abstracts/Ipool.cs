namespace Beck.Pooling
{
    public interface IPool<T>
    {
        T GetInstance();
    }
}