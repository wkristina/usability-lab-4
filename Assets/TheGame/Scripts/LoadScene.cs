using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LoadScene : MonoBehaviour
{

    // Quelle: https://loekvandenouweland.com/content/use-unity-button-to-change-between-scenes.html
    public void GotoMainScene()
    {
        SceneManager.LoadScene("Main");
    }

    public void GotoFirstScene()
    {
        SceneManager.LoadScene("First");
    }

    // Bei Erweiterung um weitere Szenen, neue Methoden nach dem gleichen Muster einfügen
    
}
