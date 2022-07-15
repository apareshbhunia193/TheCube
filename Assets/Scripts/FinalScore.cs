using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FinalScore : MonoBehaviour
{
    [SerializeField] TMP_Text finalScoreText;
    // Start is called before the first frame update
    void Start()
    {
        finalScoreText.text = "Score : " + GameManager.instance.GetScore();
    }

}
