using UnityEngine;

public class LocationUIView : UIBaseView<LocationData>
{
    [SerializeField] private TMPro.TextMeshProUGUI nameText;
    [SerializeField] private TMPro.TextMeshProUGUI descriptionText;
    [SerializeField] private UnityEngine.UI.Image locationImage;

    public override void OnSelected(LocationData data)
    {
        nameText.text = data.DisplayName;
        descriptionText.text = data.Description;
        locationImage.sprite = data.Image;
    }
}
