using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shopTrigger : MonoBehaviour
{
    public GameObject txt;
    public GameObject panel;

    // Start is called before the first frame update
    void Start()
    {
        txt.SetActive(false);
        panel.SetActive(false);

        PlayerPrefs.SetFloat("Money", 0);
    }

    // Update is called once per frame
    void Update()
    {
        //Sell One Green
        if (panel.activeSelf && Input.GetKeyDown("1") && PlayerPrefs.GetFloat("Total Green") > 0)
        {
            float x = PlayerPrefs.GetFloat("Money");
            PlayerPrefs.SetFloat("Money", x + 1);

            float y = PlayerPrefs.GetFloat("Total Green");
            PlayerPrefs.SetFloat("Total Green", y - 1);
        }

        //Sell One Blue
        if (panel.activeSelf && Input.GetKeyDown("2") && PlayerPrefs.GetFloat("Total Blue") > 0)
        {
            float x = PlayerPrefs.GetFloat("Money");
            PlayerPrefs.SetFloat("Money", x + 2);

            float y = PlayerPrefs.GetFloat("Total Blue");
            PlayerPrefs.SetFloat("Total Blue", y - 1);
        }

        //Sell One Red
        if (panel.activeSelf && Input.GetKeyDown("3") && PlayerPrefs.GetFloat("Total Red") > 0)
        {
            float x = PlayerPrefs.GetFloat("Money");
            PlayerPrefs.SetFloat("Money", x + 3);

            float y = PlayerPrefs.GetFloat("Total Red");
            PlayerPrefs.SetFloat("Total Red", y - 1);
        }


        // Sell All
        if (panel.activeSelf && Input.GetKeyDown("4") && PlayerPrefs.GetFloat("Total Red") + PlayerPrefs.GetFloat("Total Blue") + PlayerPrefs.GetFloat("Total Green") > 0)
        {
            float sum = 0;

            sum += PlayerPrefs.GetFloat("Total Green");
            sum += PlayerPrefs.GetFloat("Total Blue") * 2;
            sum += PlayerPrefs.GetFloat("Total Red") * 3;

            PlayerPrefs.SetFloat("Total Green", 0);
            PlayerPrefs.SetFloat("Total Blue", 0);
            PlayerPrefs.SetFloat("Total Red", 0);

            PlayerPrefs.SetFloat("Money", PlayerPrefs.GetFloat("Money") + sum);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        txt.SetActive(true);
    }

    public void OnTriggerStay(Collider other)
    {
        if (Input.GetAxis("Fire2") > 0)
        {
            panel.SetActive(true);
            txt.SetActive(false);
        }

        if(Input.GetAxis("Fire3") > 0)
        {
            panel.SetActive(false);
            txt.SetActive(true);
        }
       
        
    }


    private void OnTriggerExit(Collider other)
    {
        txt.SetActive(false);
        panel.SetActive(false);
    }
}
