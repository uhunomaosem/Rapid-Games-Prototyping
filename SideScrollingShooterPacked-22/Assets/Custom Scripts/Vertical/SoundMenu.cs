using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundMenu : MonoBehaviour
{

    public GameObject soundmenu;
    public GameObject pausemenu;
    public bool isSound;

    public PauseMenu pauseMenuScript;
    void Start()
    {
        soundmenu.SetActive(false);
    }

    void Update()
    {


        //if (Input.GetKeyDown(KeyCode.Escape))
        //{
        //    if (isSound)
        //    {
        //        CloseSoundMenu();
        //    }
            

        //}

    }

    //private void CloseSoundMenu()
    //{
        
    //    pauseMenuScript.isPaused = true;
    //    soundmenu.SetActive(false);
    //    pausemenu.SetActive(true);
    //    isSound = false;

    //}
}
