using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class PauseMenu : MonoBehaviour
{
    private bool isGamePaused = false;

    public GameObject pauseMenu_obj;

    public bool isGameOver = false;

    public GameObject player, pistol;

    public AudioSource music; 


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P) && !isGameOver)
        {
            if (isGamePaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }

    private void PauseGame()
    {
        // Pause Game
        Time.timeScale = 0;

        // Pause Music
        music.Pause();

        // Disable Player Movement and Shooting
        player.GetComponent<PlayerMovement>().enabled = false;
        pistol.GetComponent<WeaponControl>().enabled = false;

        // Set Cursor
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;

        // Pause Menu
        pauseMenu_obj.SetActive(true);

        // Set Boolean
        isGamePaused = true;
    }

    private void ResumeGame()
    {
        // Resume Game
        Time.timeScale = 1;

        // Resume Music
        music.UnPause();

        // Enable Player Movement and Shooting
        player.GetComponent<PlayerMovement>().enabled = true;
        pistol.GetComponent<WeaponControl>().enabled = true;

        // Set Cursor
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

        // Pause Menu
        pauseMenu_obj.SetActive(false);

        // Set Boolean
        isGamePaused = false;
    }

}
