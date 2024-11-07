namespace genery5
{
    interface IStorage<T>
    {
        int Get(T element);
        void Add(T value);
    }
}
