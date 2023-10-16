using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : GameManager
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Next"))
        {
            SceneManager.LoadScene("Tutorial 2");
        }

        if(other.gameObject.CompareTag("Level 1"))
        {
            SceneManager.LoadScene("Level 1");
        }
        
        if(other.gameObject.CompareTag("Level 2"))
        {
            SceneManager.LoadScene("Level 2");
        }
        
        if(other.gameObject.CompareTag("Level 3"))
        {
            SceneManager.LoadScene("Level 3");
        }
        
        if(other.gameObject.CompareTag("Level 4"))
        {
            SceneManager.LoadScene("Level 4");
        }

        if (other.gameObject.CompareTag("Hazard"))
        {
            Scene scene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(scene.buildIndex);
        }

        if(other.gameObject.CompareTag("Win"))
        {
            Time.timeScale = 0;
            winPanel.SetActive(true);
        }
    }
}
