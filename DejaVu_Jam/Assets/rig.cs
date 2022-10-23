using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rig : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("End", 5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void End()
    {
        Application.Quit();
    }
}
