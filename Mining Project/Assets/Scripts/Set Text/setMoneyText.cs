using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class setMoneyText : MonoBehaviour
{
    float tot = 0;
    public GameObject txt;
    private string total;
    // Start is called before the first frame update
    void Start()
    {
        total = ("$" + tot);
        txt.GetComponent<Text>().text = total;
    }

    // Update is called once per frame
    void Update()
    {
        tot = PlayerPrefs.GetFloat("Money");
        total = ("$ " + tot);
        txt.GetComponent<Text>().text = total;
    }
}
