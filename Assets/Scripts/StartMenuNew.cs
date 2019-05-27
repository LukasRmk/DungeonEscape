using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenuNew : MonoBehaviour
{
    CharacterMov player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<CharacterMov>();
        Cursor.visible = true;
    }

    public void Continue()
    {
        player.Load();
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("1st level");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void ToMenu()
    {
        SceneManager.LoadScene(0);
    }
}
