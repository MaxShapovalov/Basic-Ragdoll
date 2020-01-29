using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Animator anim;
    Rigidbody rb;
    float vertical;
    float horizontal;
    float verticalRaw;
    float horizontalRaw;

    Vector3 targetRotation;
    public float rotationSpeed;
    
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        horizontalRaw = Input.GetAxis("Horizontal");
        verticalRaw = Input.GetAxis("Vertical");

        Vector3 input = new Vector3(-vertical, 0, horizontal);
        Vector3 inputRaw = new Vector3(horizontalRaw, 0, verticalRaw);

        if (input.sqrMagnitude > 1.0f) {
            input.Normalize();
        }
        if (inputRaw != Vector3.zero){
            targetRotation = Quaternion.LookRotation(input).eulerAngles;
            rb.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(targetRotation.x, Mathf.Round(targetRotation.y / 45) * 45, targetRotation.z-90),Time.deltaTime*rotationSpeed);
            
        }
        if (inputRaw.sqrMagnitude != 0)
        {
            anim.enabled = true;
        }
        else if (inputRaw.sqrMagnitude == 0) {
            anim.enabled = false;
        }
        
    }
}
