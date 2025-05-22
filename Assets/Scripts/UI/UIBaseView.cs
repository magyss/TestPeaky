using UnityEngine;

public abstract class UIBaseView<T> : MonoBehaviour, ISelectionHandler<T> where T : IData
{
    public abstract void OnSelected(T data);
}
