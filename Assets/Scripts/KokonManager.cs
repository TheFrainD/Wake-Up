using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KokonManager : MonoBehaviour
{
    int cocons = 3;
    public GameObject canvas;

    public void KokonDestroyed() {
        cocons--;
    }

    private void Update() {
        if (cocons == 0) {
            Invoke("ShowCanvas", 3f);
        }
    }

    void ShowCanvas() {
        canvas.SetActive(true);
        Invoke("LevelPassed", 3f);
        FindObjectOfType<PlayerTopdownController>().canMove = false;
    }

    void LevelPassed() {
        SceneManager.LoadScene("Final Scene");
    }
}
