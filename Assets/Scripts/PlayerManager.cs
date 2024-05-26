using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    private bool player_alive = true;
    public GameObject death_effect;

    public GameObject hand;
    public GameObject crosshair;
    public GameObject gameOverMenu;
    public PauseMenu pause_menu;

    public void Death()
    {
        if(player_alive)
        {
            // Set Player Dead
            player_alive = false;

            // Disable Pause Menu
            pause_menu.isGameOver = true;
            
            // Particle Effect
            Instantiate(death_effect, transform.position, Quaternion.identity);

            // Disable Player
            GetComponent<PlayerMovement>().enabled = false;
            hand.SetActive(false);
            crosshair.SetActive(false);

            // Cursor Activation
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;

            // Enable GameOver Menu
            gameOverMenu.SetActive(true);
        }
    }
}
