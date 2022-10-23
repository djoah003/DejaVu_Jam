using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class PISTELASKURI : MonoBehaviour
{
    public float pisteet = 0;
    public float x = 0; // Syd‰mmien m‰‰r‰.
    //public TextMeshProUGUI pisteetTeksti;
    public bool HasEnded = false;
    public Sprite Img0, Img25, Img50, Img60, Img69, Img79, Img86, Img93, Img100, Win, Lose;
    public Image HeartMeter, Ending;

    // Start is called before the first frame update
    void Start()
    {
        //pisteetTeksti.text = "Pisteet: " + pisteet;
        HeartMeter.GetComponent<Image>();
        Ending.GetComponent<Image>();
        Ending.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        //pisteetTeksti.text = "Pisteet: " + pisteet;
        PointImage();
        if (HasEnded)
        Invoke("EndingCheck", 3);
    }


    void EndingCheck()
    {
        Ending.enabled = true;
        if (x * 0.86 <= pisteet) // Jos pisteet ylitt‰‰ 86 % --> True Ending
        {
            print("TrueEnding");
            Ending.sprite = Win;
        }
        else if (x * 0.69 <= pisteet) // Jos pisteet ylitt‰‰ 69 % --> Good Ending
        {
            print("GoodEnding");
            Ending.sprite = Win;
        }
        else if (x * 0.50 <= pisteet) // Jos pisteet ylitt‰‰ 50 % --> Normal Ending
        {
            print("NormalEnding");
            Ending.sprite = Win;
        }
        else if (x * 0.5 > pisteet) // Jos pisteet alle 50 % --> Bad Ending
        {
            print("BadEnding");
            Ending.sprite = Lose;
        }
        Invoke("NextScene", 5);
    }
    void PointImage()
    {
        if (x * 1 <= pisteet) 
        {
            HeartMeter.sprite = Img100;
        }
        else if (x * 0.93 <= pisteet) 
        {
            HeartMeter.sprite = Img93;
        }
        else if (x * 0.86 <= pisteet) 
        {
            HeartMeter.sprite = Img86;
        }
        else if (x * 0.79 <= pisteet) 
        {
            HeartMeter.sprite = Img79;
        }
        else if (x * 0.69 <= pisteet) 
        {
            HeartMeter.sprite = Img69;
        }
        else if (x * 0.60 <= pisteet) 
        {
            HeartMeter.sprite = Img60;
        }
        else if (x * 0.50 <= pisteet) 
        {
            HeartMeter.sprite = Img50;
        }
        else if (x * 0.25 <=pisteet) 
        {
            HeartMeter.sprite = Img25;
        }
        else
        {
            HeartMeter.sprite = Img0;
        }
    }

    void NextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
