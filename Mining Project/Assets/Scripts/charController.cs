using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charController : MonoBehaviour
{

    private float horInput;
    private float vertInput;
    public float speed;

    private float rotY = 0f;
    public float sensitivity = 1;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rotY += Input.GetAxis("Mouse X") * sensitivity;


        horInput = Input.GetAxis("Horizontal");
        vertInput = Input.GetAxis("Vertical");

        transform.localEulerAngles = new Vector3(0, rotY, 0);

        transform.Translate(Vector3.forward * speed * vertInput * Time.deltaTime);
        transform.Translate(Vector3.right * speed * horInput * Time.deltaTime);


    }
}
