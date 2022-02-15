using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animControl : MonoBehaviour
{
   
   
    // Start is called before the first frame update
    void Start()
    {
        Animator animControl = GetComponent<Animator>();
        animControl.StopPlayback();
        
    }
    // Update is called once per frame
    void LateUpdate()
    {
        Animator animControl = GetComponent<Animator>();
   
        if (Input.GetAxis("Fire1") > 0)
        {
            animControl.Play("pickAnimation");
        }
        else
        {
            animControl.Play("Exit");
        }
        
    }


}
