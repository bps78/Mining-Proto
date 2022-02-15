using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class redMining : MonoBehaviour
{

    public float leftClick = 0;
    public float timeMine = 0;
    public bool near = false;
    public float redMined;
    public GameObject redRock;
    public ParticleSystem redPart;

    private float totRed = 0;

    Vector3 ogSize;

    // Start is called before the first frame update
    void Start()
    {
        redPart.Pause();
        PlayerPrefs.SetFloat("Total Red", 0);
        ogSize = redRock.transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        leftClick = Input.GetAxis("Fire1");

        if (near == true)
        {
            if (leftClick > 0)
            {
                redPart.enableEmission = true;
                redPart.Play();
                timeMine += (1 * Time.deltaTime);
            }
            else
            {
                redPart.enableEmission = false;
            }
        }
        else
        {
            redPart.enableEmission = false;
        }
        checkMined();
        //Size Control
        redRock.transform.localScale = new Vector3((float)ogSize.x * ((7.5f - timeMine) / 7.5f) + 1, (float)ogSize.y, (float)ogSize.z * ((7.5f - timeMine) / 7.5f) + 1);
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
        if (timeMine >= 7.5)
        {
            Destroy(redRock);

            totRed = PlayerPrefs.GetFloat("Total Red");
            PlayerPrefs.SetFloat("Total Red", totRed + 1);

            redPart.enableEmission = false;
        }
    }
}
