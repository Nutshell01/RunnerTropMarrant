using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
  
  public void StartGame()
  {
       SceneManager.LoadScene(1); //1 étant l'index de la scène game
  }

  public void Quit()
  {
      Application.Quit();
  }
}
