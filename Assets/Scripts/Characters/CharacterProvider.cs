using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Provider/CharacterProvider")]
public class CharacterProvider : ScriptableObject, IDataProvider<CharacterData>
{
    [SerializeField] private List<CharacterData> characters;

    public IEnumerable<CharacterData> GetAll() => characters;
}
