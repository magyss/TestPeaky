using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject characterUIPrefab;
    [SerializeField] private GameObject locationUIPrefab;

    private GameObject currentUI;

    public void LoadUI(GameObject prefab)
    {
        if (currentUI != null)
            Destroy(currentUI);

        currentUI = Instantiate(prefab, transform);
    }
}
