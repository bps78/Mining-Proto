using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class spawnManager : MonoBehaviour
{
    public GameObject blueRock;
    public GameObject redRock;
    public GameObject greenRock;
    public float xLow, xHigh, zLow, zHigh;
    float[] zCords = new float[9];
    float[] xCords = new float[9];
    int index = 0;


    // This determines how close the rocks will be allowed to be to each other when spawned
    public float gap;


    // Start is called before the first frame update
    void Start()
    {
        //Time loop repeats determines how many of each rock
        for(int i = 0; i < 3; i++)
        {
            //Creation of Blue clones
            float xCord = generateX();
            float zCord = generateZ();
            xCords[index] = xCord;
            zCords[index] = zCord;
            index++;
            Vector3 bluePosition = new Vector3(xCord, blueRock.transform.position.y, zCord);
            

            Instantiate(blueRock, bluePosition, blueRock.transform.rotation);


            //Creation of Red clones
            float xCordRed = generateX();
            float zCordRed = generateZ();
            xCords[index] = xCordRed;
            zCords[index] = zCordRed;
            index++;
            Vector3 redPosition = new Vector3(xCordRed, redRock.transform.position.y, zCordRed);
            

            Instantiate(redRock, redPosition, redRock.transform.rotation);


            //Creation of Green clones
            float xCordGreen = generateX();
            float zCordGreen = generateZ();

            xCords[index] = xCordGreen;
            zCords[index] = zCordGreen;
            index++;

            Vector3 greenPosition = new Vector3(xCordGreen, redRock.transform.position.y, zCordGreen);
           

            Instantiate(greenRock, greenPosition, greenRock.transform.rotation);
        }
        Destroy(blueRock);
        Destroy(redRock);
        Destroy(greenRock);
    }

    //This method checks to make sure that x cords dont intersect and corrects it if they do
    float generateX()
    {
        float newX = Random.Range(xLow, xHigh);
        while (isOverlappingX(newX, xCords))
        {
            newX = Random.Range(xLow, xHigh);
        }


        return newX;
    }

    //This method checks to make sure that z cords dont intersect and corrects it if they do
    float generateZ()
    {

        float newZ = Random.Range(zLow, zHigh);
        while (isOverlappingZ(newZ, zCords))
        {
            newZ = Random.Range(zLow, zHigh);
        }


        return newZ;
    }


    //This method returns a bool value that represents if the param is within the gap distance of an existing cord
    bool isOverlappingZ(float newZ, float[] zCords)
    {
        foreach(float cur in zCords){
            if(Mathf.Abs(newZ - cur) <= gap)
            {
                return true;
            }
        }
        return false;
    }


    //This method returns a bool value that represents if the param is within the gap distance of an existing cord
    bool isOverlappingX(float newX, float[] xCords)
    {
        foreach (float cur in xCords)
        {
            if (Mathf.Abs(newX - cur) <= gap)
            {
                return true;
            }
        }
        return false;
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
