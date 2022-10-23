using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Liikkuja : MonoBehaviour
{
    public float nopeus;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.position += new Vector3(0, 0, -nopeus) * Time.deltaTime;
    }
}
