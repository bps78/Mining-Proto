using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class setGreenText : MonoBehaviour
{
    public GameObject txt;
    private string rocks;


    // Start is called before the first frame update
    void Start()
    {
        rocks = "Green: " + PlayerPrefs.GetFloat("Total Green");
        txt.GetComponent<Text>().text = rocks;
    }

    // Update is called once per frame
    void Update()
    {
        rocks = "Green: " + PlayerPrefs.GetFloat("Total Green");
        txt.GetComponent<Text>().text = rocks;
    }
}