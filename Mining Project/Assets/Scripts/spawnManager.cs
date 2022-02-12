using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class spawnManager : MonoBehaviour
{
    public GameObject blueRock;
    public GameObject redRock;
    public GameObject greenRock;
    public float xLow, xHigh, zLow, zHigh;
    public int spawnReps;
  


    // This determines how close the rocks will be allowed to be to each other when spawned
    public float gap;


    // Start is called before the first frame update
    void Start()
    {
        //Time loop repeats determines how many of each rock
        for(int i = 0; i < spawnReps; i++)
        {
            //Creation of Blue clones
            
            Vector3 bluePosition = genCord();


            Instantiate(blueRock, bluePosition, blueRock.transform.rotation);


            //Creation of Red clones
          
            Vector3 redPosition = genCord();


            Instantiate(redRock, redPosition, redRock.transform.rotation);


            //Creation of Green clones

            Vector3 greenPosition = genCord();
           

            Instantiate(greenRock, greenPosition, greenRock.transform.rotation);
        }
        Destroy(blueRock);
        Destroy(redRock);
        Destroy(greenRock);
    }

    //Generates a random coordinate
    Vector3 genCord()
    {
        return new Vector3(Random.Range(xLow, xHigh), (float)-2.7, Random.Range(xLow, xHigh));
    }





    // Update is called once per frame
    void Update()
    {
        
    }
}
