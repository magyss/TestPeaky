using UnityEngine;

[CreateAssetMenu(menuName = "Data/Character")]
public class CharacterData : ScriptableObject, IData
{
    [SerializeField] private string id;
    [SerializeField] private string displayName;
    [SerializeField] private int level;
    [SerializeField] private Sprite avatar;

    public string Id => id;
    public string DisplayName => displayName;
    public int Level => level;
    public Sprite Avatar => avatar;
}
