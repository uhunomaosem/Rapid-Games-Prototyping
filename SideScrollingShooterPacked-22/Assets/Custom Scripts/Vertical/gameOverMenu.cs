using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameOverMenu : MonoBehaviour
{
    public GameObject gameOverScreen;

    private void Start()
    {
        gameOverScreen.SetActive(false);

    }

    private void OnEnable()
    {
        HealthComponent.onPlayerDeath += enableGameOverMenu;
    }

    private void OnDisable()
    {
        HealthComponent.onPlayerDeath -= enableGameOverMenu;
    }

    public void enableGameOverMenu()
    {
        gameOverScreen.SetActive(true);
        Time.timeScale = 0f;
    }

    public void restartLevel()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("VerticalScroller");
    }


}
