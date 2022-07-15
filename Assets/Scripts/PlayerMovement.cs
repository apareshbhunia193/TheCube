using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;
    [SerializeField] float rotationalSpeed = 50f;
    [SerializeField] Animator anim;
    Rigidbody rigidbody1;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody1 = GetComponent<Rigidbody>();
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
            rigidbody1.isKinematic = false;
            anim.SetBool("isRunning",true);
        }else
        {
            rigidbody1.isKinematic = true;
            anim.SetBool("isRunning", false);
        }
    }
}
