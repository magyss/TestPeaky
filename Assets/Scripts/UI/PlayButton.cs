using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
    [SerializeField]
    public int id;

    public void Play() {
        SceneManager.LoadScene(id);
    }
}
