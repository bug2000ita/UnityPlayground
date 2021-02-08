using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject[] items;
    private float delay = 1;
    private float repeatSpawn = 1.5f;
    public int score = 0;

    public TextMeshProUGUI ScoreText;
    public TextMeshProUGUI GameOverText;
    public Button RestartButton;

    public bool isGameOver;
    private GameObject titleScreen;

    // Start is called before the first frame update
    void Start()
    {
        titleScreen = GameObject.Find("Title Screen");
    }

    IEnumerator SpawnTargets()
    {
        while (!isGameOver)
        {
            yield return new WaitForSeconds(repeatSpawn);
            SpawnTarget();
        }
            
    }

    public void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        ScoreText.text = "Score: " + score;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnTarget()
    {
        int randomIndex = Random.Range(0, 4);
        Instantiate(items[randomIndex]);
    }

    public void GameOver()
    {
        GameOverText.gameObject.SetActive(true);
        isGameOver = true;
        RestartButton.gameObject.SetActive(true);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        titleScreen.SetActive(true);
    }

    public void StartGame(int difficulty)
    {
        repeatSpawn /= difficulty;
        UpdateScore(0);
        isGameOver = false;
        titleScreen.SetActive(false);
        //InvokeRepeating("SpawnTarget", delay, repeat);

        StartCoroutine(SpawnTargets());


    }


}
