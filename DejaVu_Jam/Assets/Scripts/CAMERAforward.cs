using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CAMERAforward : MonoBehaviour
{
    public float speed;
    public GameObject CAR = null;
    public float z;
    public float y;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        z = z + (CAR.transform.position.z - z) * Time.deltaTime;
        y = y + (CAR.transform.position.y - y) * Time.deltaTime;
        transform.position = new Vector3(0, 10, z);

    }
}
