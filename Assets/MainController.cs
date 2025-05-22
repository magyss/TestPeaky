using UnityEngine;
using System.Linq;

public class MainController : MonoBehaviour
{
    [Header("Character")]
    [SerializeField] private CharacterProvider characterProvider;
    [SerializeField] private CharacterUIView characterUIView;
    [SerializeField] private CharacterSelector characterSelector;

    [Header("Location")]
    [SerializeField] private LocationProvider locationProvider;
    [SerializeField] private LocationUIView locationUIView;
    [SerializeField] private LocationSelector locationSelector;


    private void OnCharacterSelectedByIndex(int index)
    {
        var characters = characterProvider.GetAll();
        var characterArray = characters as CharacterData[] ?? characters.ToArray();

        if (index >= 0 && index < characterArray.Length)
        {
            characterSelector.SelectCharacter(characterArray[index].Id);
        }
    }

    public void OnLocationButtonClicked(int index)
    {
        var locations = locationProvider.GetAll();
        var locationArray = locations as LocationData[] ?? locations.ToArray();

        if (index >= 0 && index < locationArray.Length)
        {
            locationSelector.SelectLocation(locationArray[index].Id);
        }
    }
}
