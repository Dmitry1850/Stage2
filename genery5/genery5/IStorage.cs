namespace genery5
{
    interface IStorage<T>
    {
        T Get(int element);
        void Add(T value);
    }
}
