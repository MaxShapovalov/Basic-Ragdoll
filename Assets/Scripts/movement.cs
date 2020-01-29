using UnityEngine;
using System.Collections;

public class movement : MonoBehaviour
{
   
    Animator m_Animator;
    public float WalkSpeed=1.0f;
    public float thrust = 1.0f;
    public float floatForce = 0.01f;
    public Rigidbody rb;
    
    //public GameObject leftArm;
    //public GameObject rightArm;

    // Use this for initialization
    void Start()
    {
        //rb = GetComponent<Rigidbody>();
        m_Animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
        //if (Input.GetKeyDown(KeyCode.LeftArrow))
        //{
        //    StartCoroutine(Rotate(Vector3.up, -90, 1.0f));
        //}
        //if (Input.GetKeyDown(KeyCode.RightArrow))
        //{
        //    StartCoroutine(Rotate(Vector3.up, 90, 1.0f));
        //}
        //if (Input.GetKeyDown(KeyCode.UpArrow))
        //{
        //    StartCoroutine(Rotate(Vector3.up, 180, 1.0f));
        //}
        //if (Input.GetKeyDown(KeyCode.DownArrow))
        //{
        //    StartCoroutine(Rotate(Vector3.up, -180, 1.0f));
        //}
        rb.AddForce(0, floatForce, 0, ForceMode.Impulse);

        if (Input.GetKey(KeyCode.LeftArrow))
        {


            
            rb.AddForce(-thrust, 0, 0, ForceMode.Impulse);
            //transform.Translate(Vector3.left * WalkSpeed * Time.deltaTime);


            
            m_Animator.SetTrigger("moving");
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {

            
            rb.AddForce(thrust, 0, 0, ForceMode.Impulse);
            //transform.Translate(Vector2.right * WalkSpeed * Time.deltaTime);
            m_Animator.SetTrigger("moving");
        }
       if (Input.GetKey(KeyCode.UpArrow))
        {

            //transform.forward = new Vector3(0f, 0f, 1f);
            rb.AddForce(0, 0, thrust, ForceMode.Impulse);
            //transform.Translate(Vector3.forward * WalkSpeed * Time.deltaTime);
            m_Animator.SetTrigger("moving");
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.AddForce(0, 0, -thrust, ForceMode.Impulse);

            // transform.Translate(Vector3.back * WalkSpeed * Time.deltaTime);

            // m_Animator.SetTrigger("moving");
        }
        else {
            //m_Animator.SetTrigger("idle");
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            
        }

        //IEnumerator Rotate(Vector3 axis, float angle, float duration = 0.1f)
        //{
        //    Quaternion from = transform.rotation;
        //    Quaternion to = transform.rotation;
        //    to *= Quaternion.Euler(axis * angle);

        //    float elapsed = 0.0f;
        //    while (elapsed < duration)
        //    {
        //        transform.rotation = Quaternion.Slerp(from, to, elapsed / duration);
        //        elapsed += Time.deltaTime;
        //        yield return null;
        //    }
        //    transform.rotation = to;
        //}
        

    }
}





    
       

    
