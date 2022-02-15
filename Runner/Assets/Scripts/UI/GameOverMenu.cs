using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameOverMenu : MonoBehaviour
{

    public void Restart()
    {
        SceneManager.LoadScene(1); //1 étant l'index de la scène game
    }
    public void QuitToMain()
    {
        SceneManager.LoadScene(0); //0 étant l'index de la scène Main menu
    }
}
