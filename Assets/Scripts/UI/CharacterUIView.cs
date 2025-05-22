using UnityEngine;


public class CharacterUIView : UIBaseView<CharacterData>
{
    [SerializeField] private TMPro.TextMeshProUGUI nameText;
    [SerializeField] private TMPro.TextMeshProUGUI levelText;
    [SerializeField] private UnityEngine.UI.Image avatarImage;

    public override void OnSelected(CharacterData data)
    {
        nameText.text = data.DisplayName;
        levelText.text = "Level " + data.Level;
        avatarImage.sprite = data.Avatar;
    }
}
