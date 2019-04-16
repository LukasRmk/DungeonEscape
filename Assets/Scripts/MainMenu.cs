﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    CharacterMov character;

    private void Start()
    {
        Cursor.visible = true;
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