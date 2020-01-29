using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class feet : MonoBehaviour
{
    public Rigidbody playerRb;
    public CapsuleCollider playerSupporter;
    public float timeLeft = 2.5f;
    public float getUpTime = 2.5f;
    private float selectedTime;
    private float selectedJumpDamp;
    private bool falling;
    public bool idiotJumpMode;

    public float thrust = 1.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        selectedTime = timeLeft;
        
        
    }
    
    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerRb.AddForce(new Vector3(0, 1000, 0), ForceMode.Impulse);
            playerRb.constraints = RigidbodyConstraints.None;
            //jumpDamp = thrust * 0.9f;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            playerRb.AddForce(-thrust, 0, 0, ForceMode.Impulse);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            playerRb.AddForce(thrust, 0, 0, ForceMode.Impulse);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            playerRb.AddForce(0, 0, thrust, ForceMode.Impulse);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            playerRb.AddForce(0, 0, -thrust, ForceMode.Impulse);
        }


        //timeLeft -= Time.deltaTime;
        //if (timeLeft < 0)
        //{
        //    if (playerSupporter.enabled == true)
        //    {
        //        RemoveCollider();
        //    }

        //}
        //else {
        //    falling = true;
        //    StartCoroutine(ExampleCoroutine());
            
            
        //}
        

    }
  
    
        void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.tag == "ground")
        {
            
                timeLeft = selectedTime;

            playerRb.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;
            
        }
        
        }
    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "ground"&&idiotJumpMode==true)
        {
            playerRb.constraints = RigidbodyConstraints.None;
        }
    }
    //    IEnumerator ExampleCoroutine()
    //{

    //    if (falling==true)
    //    {
            
    //        yield return new WaitForSeconds(getUpTime);
    //        playerSupporter.enabled = true;
    //        falling = false;
    //    }
    //}

}

