using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CAMERAforward : MonoBehaviour
{
    public float speed;
    public GameObject CAR = null;
    public GameObject KAISTA = null;
    public float z;
    public float x;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //z = z + (CAR.transform.position.z - z) * Time.deltaTime;
        x = x + (CAR.transform.position.x - x) * Time.deltaTime;
        transform.position = new Vector3(x, 7, -30);

    }
}
