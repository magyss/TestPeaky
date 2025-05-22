public class SelectionContainer<T> where T : IData
{
    public T CurrentSelection { get; private set; }

    public void SetSelection(T selection)
    {
        CurrentSelection = selection;
    }
}
