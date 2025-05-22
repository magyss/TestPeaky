using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Provider/LocationProvider")]
public class LocationProvider : ScriptableObject, IDataProvider<LocationData>
{
    [SerializeField] private List<LocationData> locations;

    public IEnumerable<LocationData> GetAll() => locations;
}
