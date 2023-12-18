using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menustart : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadSceneAsync("alpha version");
    }
}
