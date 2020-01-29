using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class motion : MonoBehaviour
{
    private HingeJoint hj;
    public Transform myAnim;
    public bool mirror;
    // Start is called before the first frame update
    void Start()
    {
        hj = GetComponent<HingeJoint>();

    }

    // Update is called once per frame
    void Update()
    {
        if (myAnim != null) {
            JointSpring js = hj.spring;
            
            js.targetPosition = myAnim.localEulerAngles.z;
            if (js.targetPosition>180) {
                js.targetPosition = js.targetPosition - 360;
                js.targetPosition = Mathf.Clamp(js.targetPosition, hj.limits.min + 5, hj.limits.max - 5);
            }
            if (mirror) {
               js.targetPosition=js.targetPosition *= -1;
            }
            hj.spring = js;
            
            //transform.rotation = Quaternion.Lerp(transform.rotation, hj.transform.rotation, Time.deltaTime);

        }
        
        
    }
}
