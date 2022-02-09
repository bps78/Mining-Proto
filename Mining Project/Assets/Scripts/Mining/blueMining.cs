using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blueMining : MonoBehaviour
{

    public float leftClick = 0;
    public float timeMine = 0;
    public bool near = false;
    public float blueMined;
    public GameObject blueRock;
    public ParticleSystem blueParts;

    private float totBlue = 0;
   
    

    // Start is called before the first frame update
    void Start()
    {
        blueParts.Pause();
        PlayerPrefs.SetFloat("Total Blue", 0);
        
    }

    // Update is called once per frame
    void Update()
    {
        leftClick = Input.GetAxis("Fire1");

        if(near == true)
        {
            if(leftClick > 0)
            {
                blueParts.enableEmission = true;
                 blueParts.Play();
                timeMine += (1 * Time.deltaTime);
            }
            else
            {
                blueParts.enableEmission = false;
                
            }

        }
        else
        {
            blueParts.enableEmission = false;
            
        }
        
        checkMined();
    }

    private void OnTriggerEnter(Collider other)
    {
        near = true;
        
    }


    private void OnTriggerExit(Collider other)
    {
        near = false;
        
    }

    private void checkMined()
    {
        if(timeMine >= 5)
        {
            Destroy(blueRock);

            totBlue = PlayerPrefs.GetFloat("Total Blue");
            PlayerPrefs.SetFloat("Total Blue", totBlue + 1);


            blueParts.enableEmission = false;
            
        }
    }
}
