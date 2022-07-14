using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;
    [SerializeField] float rotationalSpeed = 50f;
    [SerializeField] Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 moveDir = new Vector3(0f, 0f, Input.GetAxisRaw("Vertical"));
        Vector3 movement = (transform.forward * moveDir.z);
        Vector3 rotDir = new Vector3(0f,Input.GetAxisRaw("Horizontal"),0f);
        transform.position += movement * moveSpeed * Time.deltaTime;
        transform.Rotate(rotDir * rotationalSpeed * Time.deltaTime);
        if (movement.magnitude > 0) {
            anim.SetBool("isRunning",true);
        }else
        {
            anim.SetBool("isRunning", false);
        }
    }
}
