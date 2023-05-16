using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class UIManagerLost : MonoBehaviour
{
    public Button btnRestartLevel;
    public TextMeshProUGUI txtScore;
    private float score;
    void Start()
    {
        SetBindings();
        score = PlayerPrefs.GetFloat("Score"); // Score
        txtScore.text = score.ToString("0"); // Show score
    }

    void SetBindings() // Buttons
    {
        btnRestartLevel.onClick.AddListener(call: () =>
        {
            SceneManager.LoadScene("MainScene");
        });
    }
}
