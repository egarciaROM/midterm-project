using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameState : MonoBehaviour
{
    [SerializeField] GameObject _scoreText;
    [SerializeField] GameObject _gameOverText;
    // Start is called before the first frame update

    int _score = 0;
    bool _isGameOver = false;
    public static GameState Instance;
    int finalScore;

    void Awake()
    {
        Instance = this;
    }
    /// <summary>
    //Below methods taken from my 2D tutorial project
    /// </summary>

    public bool IsGameOverScore() {
        return _score < -400 ;
        
    }

    public void IncreaseScore(int amount)
    {
        _score = _score + amount;
        _scoreText.GetComponent<Text>().text = "Score: " + _score;

    }
    public void DecreaseScore(int amount)
    {
        _score = _score - amount;
        _scoreText.GetComponent<Text>().text = "Score: " + _score;

    }


    public void InitiateGameOver()
    {
        finalScore = _score;
        _isGameOver = true;
        _gameOverText.GetComponent<Text>().text = "Game Over. Final Score " + finalScore;
        _scoreText.SetActive(false);
        _gameOverText.SetActive(true);

        //enabled = false;


    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (IsGameOverScore())
        {
            //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            InitiateGameOver();
           
        } 
    }
}
