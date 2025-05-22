using UnityEngine;

public class CharacterSelector : MonoBehaviour
{
    [SerializeField] private CharacterProvider provider;
    [SerializeField] private CharacterUIView uiView;

    private SelectionContainer<CharacterData> container;
    private SelectionManager<CharacterData> manager;

    void Awake()
    {
        container = new SelectionContainer<CharacterData>();
        manager = new SelectionManager<CharacterData>(provider, container);
        manager.RegisterHandler(uiView);
    }

    public void SelectCharacter(string id)
    {
        manager.Select(id);
    }
}
