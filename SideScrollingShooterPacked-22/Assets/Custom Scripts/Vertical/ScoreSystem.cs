using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;


public class ScoreSystem : MonoBehaviour
{

    //public static ScoreSystem Instance;

    public TMP_Text scoreText;
    public int score = 0;


    void Awake()
    {
        //if (Instance == null)
        //{
        //    DontDestroyOnLoad(gameObject);
        //    Instance = this;
        //}
        //else if(Instance != this)
        //{
        //    Destroy(gameObject);
        //}
    }

    public void AddScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = "Score: " + score;
    }

    private void Update()
    {
        if (score >= 2000)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

}
