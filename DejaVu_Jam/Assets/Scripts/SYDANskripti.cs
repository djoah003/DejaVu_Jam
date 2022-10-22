using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SYDANskripti : MonoBehaviour
{
    private PISTELASKURI pistelaskuri;
    // Start is called before the first frame update
    void Start()
    {
        pistelaskuri = GameObject.Find("PISTELASKURI").GetComponent<PISTELASKURI>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        pistelaskuri.pisteet = pistelaskuri.pisteet + 1;
        Destroy(this.gameObject);
    }
}
