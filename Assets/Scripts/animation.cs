using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animation : MonoBehaviour
{
    public GameObject[] animatorLimbs;
    public GameObject[] ragdollLimbs;
    private Vector3 startPos, endPos;
    private Quaternion startRot, endRot;
    private float lerp = 0;
    public int duration = 1;

    public int rate = 1;
    private int j = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
            if (j > rate)
            {
                j = 0;
                for (int i = 0; i < ragdollLimbs.Length; i++)
                {
                    startPos = ragdollLimbs[i].transform.position;
                    endPos = animatorLimbs[i].transform.position;

                    startRot = ragdollLimbs[i].transform.rotation;
                    endRot = animatorLimbs[i].transform.rotation;

                    lerp += Time.deltaTime / duration;

                    ragdollLimbs[i].transform.rotation = Quaternion.Lerp(startRot, endRot, lerp);
                    //ragdollLimbs[i].transform.position = Vector3.Lerp(startPos, endPos, lerp);
                }
            }
        
        j++;
    }
}
