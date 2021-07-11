using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public GameObject GameOverScreen;

    bool gameOver = false;

    public void GameOver() {
        if (!gameOver) {
            gameOver = true;
            Invoke("Restart", 4.0f);
            GameOverScreen.SetActive(true);
            FindObjectOfType<PlayerTopdownController>().canMove = false;
        }
    }

    void Restart() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
