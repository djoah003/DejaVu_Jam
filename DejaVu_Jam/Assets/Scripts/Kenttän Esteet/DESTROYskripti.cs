using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DESTROYskripti : MonoBehaviour
{
    public Vector3 position;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Destroy", 10.0f, 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Destroy()
    {
        Destroy(this.gameObject);
    }
}
