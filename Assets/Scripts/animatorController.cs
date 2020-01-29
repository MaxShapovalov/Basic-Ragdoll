using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animatorController : MonoBehaviour
{
    Animator m_Animator;
    // Start is called before the first frame update
    void Start()
    {
        m_Animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.LeftArrow))
        {
            m_Animator.SetBool("Moving", true);


        }
        else {
            m_Animator.SetTrigger("IdleTrigger");
            m_Animator.SetBool("Moving", false);
        }

    }
}
