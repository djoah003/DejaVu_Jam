using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PISTELASKURI : MonoBehaviour
{
    public float pisteet = 0;
    public TextMeshProUGUI pisteetTeksti;

    // Start is called before the first frame update
    void Start()
    {
        pisteetTeksti.text = "Pisteet: " + pisteet;
    }

    // Update is called once per frame
    void Update()
    {
        pisteetTeksti.text = "Pisteet: " + pisteet;
    }

}
