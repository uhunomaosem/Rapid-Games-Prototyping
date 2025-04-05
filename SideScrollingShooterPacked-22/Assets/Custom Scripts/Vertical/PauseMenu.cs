using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pausemenu;
    public GameObject soundmenu;
    public bool isPaused;
    public bool isSound;

    public SoundMenu soundMenuScript;
    // Start is called before the first frame update
    void Start()
    {
        pausemenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused && !soundmenu.activeSelf)
            {
                ResumeGame();
            }
            else if (isSound)
            {
                CloseSoundMenu();
            }
            else if (!isPaused && (!soundMenuScript.isSound || !soundmenu.activeSelf))
            {
                PauseGame();
            }


        }


        //if (isPaused)
        //{
        //    if (Input.GetKeyDown(KeyCode.Escape))
        //    {
        //        ResumeGame();
        //    }
        //}
    }

    public void PauseGame()
    {
         pausemenu.SetActive(true);
         Time.timeScale = 0f;
         isPaused = true;
    }

    public void ResumeGame()
    {
        pausemenu.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }

    public void goToMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Main Menu");
    }

    public void goToSoundMenu()
    {
        pausemenu.SetActive(false);
        soundmenu.SetActive(true);
        isSound = true;
        isPaused = false;

    }

    public void CloseSoundMenu()
    {
        pausemenu.SetActive(true);
        soundmenu.SetActive(false);
        isSound = false;
        isPaused = true;
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
