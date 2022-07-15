using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    //[SerializeField] TMP_Text scoreText;

    int score = 0;
    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void increaseScore() {
        score++;
        if (score == 9) {
            LoadGameOverScene();
        }
        //scoreText.text = score.ToString();
    }

    public void ReloadTheGame() {
        score = 0;
        SceneManager.LoadScene(1);
    }

    public int GetScore() {
        return score;
    }
    public void LoadGameOverScene() {
        SceneManager.LoadScene(2);
    }
}
