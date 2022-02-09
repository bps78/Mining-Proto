using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class setRedText : MonoBehaviour
{ 
public GameObject txt;
private string rocks;


// Start is called before the first frame update
void Start()
{
    rocks = "Red: " + PlayerPrefs.GetFloat("Total Red");
    txt.GetComponent<Text>().text = rocks;
}

// Update is called once per frame
void Update()
{
    rocks = "Red: " + PlayerPrefs.GetFloat("Total Red");
    txt.GetComponent<Text>().text = rocks;
}
}
