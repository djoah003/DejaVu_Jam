using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detroyer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {

        if (gameObject.tag == "Sydan")
        {
            Destroy(this.gameObject);
        }
        if (gameObject.tag == "Este")
        {
            Destroy(this.gameObject);
        }
    }
}
