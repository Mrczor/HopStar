using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManagerWin : MonoBehaviour
{
    public Button btnNextLevel;
    void Start()
    {
        SetBindings();
    }

    void SetBindings() // Buttons
    {
        btnNextLevel.onClick.AddListener(call: () =>
        {
            SceneManager.LoadScene("MainScene");
        });
    }
}
