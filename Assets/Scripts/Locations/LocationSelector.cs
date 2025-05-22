using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class LocationSelector : MonoBehaviour
{
    [SerializeField] private LocationProvider provider;
    [SerializeField] private LocationUIView uiView;

    private SelectionContainer<LocationData> container;
    private SelectionManager<LocationData> manager;

    void Awake()
    {
        container = new SelectionContainer<LocationData>();
        manager = new SelectionManager<LocationData>(provider, container);
        manager.RegisterHandler(uiView);
    }

    public void SelectLocation(string id)
    {
        manager.Select(id);
        var location = container.CurrentSelection;
        if (location != null)
        {
            GameObject.FindGameObjectWithTag("Play").GetComponent<PlayButton>().id = Convert.ToInt32(location.SceneId);
        }
    }
}
