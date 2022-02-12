using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stackedRockControl : MonoBehaviour
{
    public GameObject emptyRock;
    public ParticleSystem parts;
    public GameObject rock;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay()
    {
        System.Console.WriteLine("cool");
    }


}
