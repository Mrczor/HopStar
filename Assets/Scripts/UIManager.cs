using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class UIManager : MonoBehaviour
{
    public Button btnStart ;
    public TextMeshProUGUI txtLevel;

    void Start()
    {
        SetBindings();
        UpdateLevelText();
    }

    void SetBindings() // BUttons
    {
        btnStart.onClick.AddListener(call: () =>
        {
            SceneManager.LoadScene("MainScene");
        });
    }
    public void UpdateLevelText() // Update level text
    {
        txtLevel.text = "Level : " + PlayerPrefs.GetInt("Level").ToString();
    }
}
