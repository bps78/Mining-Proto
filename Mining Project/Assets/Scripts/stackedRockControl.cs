using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stackedRockControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.name.Substring(0, 4) == "Rock")
        {
            Destroy(this);
        }
    }
}
