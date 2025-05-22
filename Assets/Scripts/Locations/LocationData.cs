using UnityEngine;

[CreateAssetMenu(menuName = "Data/Location")]
public class LocationData : ScriptableObject, IData
{
    [SerializeField] private string id;
    [SerializeField] private string displayName;
    [SerializeField] private string description;
    [SerializeField] private Sprite image;
    [SerializeField] private string sceneId;

    public string Id => id;
    public string DisplayName => displayName;
    public string Description => description;
    public Sprite Image => image;
    public string SceneId => sceneId;
}
