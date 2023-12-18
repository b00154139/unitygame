using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public int scorePlayerRight;
    public int scorePlayerLeft;
    public GUIStyle style;

    void OnGUI() 
    {
        float x = Screen.width / 2f;
        float y = 30f;
        float height = 20f;
        string text = scorePlayerLeft + " / " + scorePlayerRight;

        GUI.Label(new Rect(x - (Screen.width / 4f), y, Screen.width / 2f, height), text, style);
    }
}
