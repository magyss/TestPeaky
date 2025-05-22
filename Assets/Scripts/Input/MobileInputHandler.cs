using System;
using UnityEngine;

public class MobileInputHandler : MonoBehaviour, IInputHandler
{
    public event Action<int> OnSelectIndex;

    public void OnButtonPressed(int index)
    {
        OnSelectIndex?.Invoke(index);
    }

    public void ProcessInput() { /* Call this manually on touch UI */ }
}
