using TMPro;
using UnityEngine;
using System.Collections.Generic;
using System.Linq;

public class CharacterDropdownUI : MonoBehaviour
{
    [SerializeField] private TMP_Dropdown dropdown;
    [SerializeField] private CharacterSelector characterSelector;
    [SerializeField] private CharacterProvider characterProvider;

    private List<CharacterData> characters;

    void Start()
    {
        characters = characterProvider.GetAll().ToList();

        dropdown.ClearOptions();
        var options = characters.Select(c => new TMP_Dropdown.OptionData(c.DisplayName)).ToList();
        dropdown.AddOptions(options);

        dropdown.onValueChanged.AddListener(OnDropdownValueChanged);

        if (characters.Count > 0)
            characterSelector.SelectCharacter(characters[0].Id);
    }

    private void OnDropdownValueChanged(int index)
    {
        if (index >= 0 && index < characters.Count)
        {
            characterSelector.SelectCharacter(characters[index].Id);
        }
    }
}