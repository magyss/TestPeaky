using System;
using UnityEngine;

public class KeyboardInputHandler : MonoBehaviour, IInputHandler
{
    public event Action<int> OnSelectIndex;

    public void ProcessInput()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1)) OnSelectIndex?.Invoke(0);
        if (Input.GetKeyDown(KeyCode.Alpha2)) OnSelectIndex?.Invoke(1);
    }

    void Update() => ProcessInput();
}
