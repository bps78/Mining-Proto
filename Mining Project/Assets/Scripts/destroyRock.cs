using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyRock : MonoBehaviour
{
    public GameObject rock;
    public ParticleSystem parts;
    public GameObject emptyRock;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      if (rock == null) { 
            
        if (parts.particleCount == 0) { 
                
           Destroy(parts);
           Destroy(emptyRock);
           Destroy(this);
        }
      }
    }
}
