using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PISTELASKURI : MonoBehaviour
{
    public float pisteet = 0;
    public float x = 0; // Syd‰mmien m‰‰r‰.
    public TextMeshProUGUI pisteetTeksti;
    public bool HasEnded = false;

    // Start is called before the first frame update
    void Start()
    {
        pisteetTeksti.text = "Pisteet: " + pisteet;
    }

    // Update is called once per frame
    void Update()
    {
        pisteetTeksti.text = "Pisteet: " + pisteet;

        if(HasEnded)
        EndingCheck();
    }

    void EndingCheck()
    {
        if (x * 0.86 <= pisteet) // Jos pisteet ylitt‰‰ 86 % --> True Ending
        {
            print("TrueEnding");
        }
        else if (x * 0.69 <= pisteet) // Jos pisteet ylitt‰‰ 69 % --> Good Ending
        {
            print("GoodEnding");
        }
        else if (x * 0.50 <= pisteet) // Jos pisteet ylitt‰‰ 50 % --> Normal Ending
        {
            print("NormalEnding");
        }
        else if (x * 0.5 > pisteet) // Jos pisteet alle 50 % --> Bad Ending
        {
            print("BadEnding");
        }
    }


}
