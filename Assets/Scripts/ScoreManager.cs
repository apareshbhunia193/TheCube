using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    [SerializeField] TMP_Text scoreText;
    private void Awake()
    {
        instance = this;
    }
    public void UpdateTheScore() {
        scoreText.text = GameManager.instance.GetScore().ToString();
    }
}
