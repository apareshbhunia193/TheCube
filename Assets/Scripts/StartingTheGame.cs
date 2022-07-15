using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartingTheGame : MonoBehaviour
{
    public void OnClickPlay() {
        SceneManager.LoadScene("Game");
    }

    public void OnClickPlayAgain() {
        GameManager.instance.ReloadTheGame();
    }
}
