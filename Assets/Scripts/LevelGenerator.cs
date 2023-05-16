using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public GameObject platfromPrefab, finishLine, jumperPlatform;
    [SerializeField] int platformCount = 20;
    private int strongPlatformCount;
    void Start()
    {
        levelGenerator();
        finishGenerator();
        strongPlatformGenerator();
    }
    Vector2 platformVector = new Vector2();
    void levelGenerator() // Create Level
    {

        for (int i = 0; i < platformCount + PlayerPrefs.GetInt("Level") * 3; i++)
        {
            GameObject tempPlatform = Instantiate(platfromPrefab);
            platformVector.x = Random.Range(-1.75f, 1.9f);
            platformVector.y += Random.Range(1.3f, 1.6f);
            tempPlatform.transform.position = platformVector;
        }
    }
    void finishGenerator() // Create finish line
    {
        Vector2 finishVector = new Vector2(0,platformVector.y);
        GameObject tempFinish = Instantiate(finishLine);
        tempFinish.transform.position = finishVector;
    }
    void strongPlatformGenerator() // Create arcs
    {
        strongPlatformCount = int.Parse((PlayerPrefs.GetInt("Level") / 3).ToString("0"));
        for (int i = 0; i < strongPlatformCount; i++)
        {
            Vector2 strongPlatformVector = new Vector2();
            GameObject tempStrongPlatform = Instantiate(jumperPlatform);
            strongPlatformVector.x = Random.Range(-1.75f, 1.9f);
            strongPlatformVector.y = Random.Range(1.3f, platformVector.y);
            tempStrongPlatform.transform.position = strongPlatformVector;
            Physics2D.OverlapBox(strongPlatformVector, strongPlatformVector, 0f);
        }
    }
}
