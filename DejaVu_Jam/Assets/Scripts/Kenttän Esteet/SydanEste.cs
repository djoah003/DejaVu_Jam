using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SydanEste : MonoBehaviour
{
    private PISTELASKURI Laskuri;
    public GameObject pistelaskuri;
    // Start is called before the first frame update
    void Start()
    {
        Laskuri = GameObject.Find("Laskuri").GetComponent<PISTELASKURI>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Este");
        if (gameObject.tag == "Sydan")
        {
            Destroy(this.gameObject);
            Laskuri.pisteet = Laskuri.pisteet + 1;


        }
        if (gameObject.tag == "Este")
        {
            Destroy(this.gameObject);
            Laskuri.pisteet = Laskuri.pisteet - 1;
 
            
        }
        
    }
}
