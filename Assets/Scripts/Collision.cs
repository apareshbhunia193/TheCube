using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    [SerializeField] AudioClip coinSound;
    Camera myCamera;

    private void Start()
    {
        myCamera = Camera.main;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Collectable")) {
            other.gameObject.SetActive(false);
            AudioSource.PlayClipAtPoint(coinSound, myCamera.transform.position);
            GameManager.instance.increaseScore();
            ScoreManager.instance.UpdateTheScore();
            Destroy(other.gameObject);
        }
    }
    private void OnCollisionEnter(UnityEngine.Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstracle"))
        {
            GameManager.instance.LoadGameOverScene();
        }
    }
}
