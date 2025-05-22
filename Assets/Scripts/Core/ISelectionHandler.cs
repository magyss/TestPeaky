public interface ISelectionHandler<T> where T : IData
{
    void OnSelected(T data);
}
