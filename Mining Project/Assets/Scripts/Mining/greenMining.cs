using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class greenMining : MonoBehaviour
{

    public float leftClick = 0;
    public float timeMine = 0;
    public bool near = false;
    public float greenMined;
    public GameObject greenRock;
    public ParticleSystem greenParts;

    private float totGreen = 0;

    Vector3 ogSize;

    // Start is called before the first frame update
    void Start()
    {
        greenParts.Pause();
        PlayerPrefs.SetFloat("Total Green", 0);
        ogSize = greenRock.transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        leftClick = Input.GetAxis("Fire1");

        if (near == true)
        {
            if (leftClick > 0)
            {
                greenParts.enableEmission = true;
                greenParts.Play();
                timeMine += (1 * Time.deltaTime);
            }
            else
            {
                greenParts.enableEmission = false;
            }
        }
        else
        {
            greenParts.enableEmission = false;
        }
        checkMined();
        greenRock.transform.localScale = new Vector3((float)ogSize.x * ((2.5f - timeMine) / 2.5f) + 1, (float)ogSize.y, (float)ogSize.z * ((2.5f - timeMine) / 2.5f) + 1);
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
        if (timeMine >= 2.5)
        {
            Destroy(greenRock);
            

            totGreen = PlayerPrefs.GetFloat("Total Green");
            PlayerPrefs.SetFloat("Total Green", totGreen + 1);

            greenParts.enableEmission = false;
        }
    }

   
}
