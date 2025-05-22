public interface ISelectable<T> where T : IData
{
    void Select(T data);
}
