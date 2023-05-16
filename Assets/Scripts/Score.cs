using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public GameObject player;
    public float score = 0;
    public TextMeshProUGUI scoreText;

    void Update() // Score calculation
    {
        if (player.transform.position.y > score)
        {
            score = player.transform.position.y;
            PlayerPrefs.SetFloat("Score", score);
            scoreText.text = score.ToString("0");
        }
    }
}
