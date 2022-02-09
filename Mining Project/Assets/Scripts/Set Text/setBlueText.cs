using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class setBlueText : MonoBehaviour
{
    public GameObject txt;
    private string rocks;


    // Start is called before the first frame update
    void Start()
    {
         rocks = "Blue: " + PlayerPrefs.GetFloat("Total Blue");
        txt.GetComponent<Text>().text = rocks;
    }

    // Update is called once per frame
    void Update()
    {
        rocks = "Blue: " + PlayerPrefs.GetFloat("Total Blue");
        txt.GetComponent<Text>().text = rocks;
    }
}
