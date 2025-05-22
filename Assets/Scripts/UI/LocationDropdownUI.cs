using TMPro;
using UnityEngine;
using System.Collections.Generic;
using System.Linq;

public class LocationDropdownUI : MonoBehaviour
{
    [SerializeField] public TMP_Dropdown dropdown;
    [SerializeField] public LocationSelector locationSelector;
    [SerializeField] public LocationProvider locationProvider;

    private List<LocationData> locations;

    void Start()
    {
        locations = locationProvider.GetAll().ToList();

        dropdown.ClearOptions();
        var options = locations.Select(l => new TMP_Dropdown.OptionData(l.DisplayName)).ToList();
        dropdown.AddOptions(options);

        dropdown.onValueChanged.AddListener(OnDropdownValueChanged);

        if (locations.Count > 0)
            locationSelector.SelectLocation(locations[0].Id);
    }

    private void OnDropdownValueChanged(int index)
    {
        if (index >= 0 && index < locations.Count)
        {
            locationSelector.SelectLocation(locations[index].Id);
        }
    }
}