using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void StartGame(string nscene)
    {
        SceneManager.LoadScene(nscene);
    }
    public void QuitGame()
    {
        Application.Quit();
        print("Quit");
    }
}
