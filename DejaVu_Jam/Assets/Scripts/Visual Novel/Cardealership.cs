using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Cardealership : MonoBehaviour
{
    public int primeInt = 1;         // This integer drives game progress!
    public Text Char1name;
    public Text Char1speech;
    public Text Char2name;
    public Text Char2speech;
    public Text Char3name;
    public Text Char3speech;
    public Text Char4name;
    public Text Char4speech;
    public GameObject DialogueDisplay;
    public GameObject ImageChar1;
    public GameObject ImageChar2;
    public GameObject ImageBG;
    public GameObject Choice1a;
    public GameObject Choice1b;
    public GameObject NextScene1Button;
    public GameObject NextScene2Button;
    public GameObject nextButton;
    //public GameHandler gameHandler;
    //public AudioSource audioSource;
    private bool allowSpace = true;

    void Start()
    {         // initial visibility settings
        DialogueDisplay.SetActive(false);
        ImageChar1.SetActive(false);
        ImageChar2.SetActive(false);
        ImageBG.SetActive(true);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        NextScene1Button.SetActive(false);
        NextScene2Button.SetActive(false);
        nextButton.SetActive(true);

        // Find the gameHandler:
        // gameHandler = GameObject.FindWithTag("GameHandler").GetComponent<GameHandler>();
    }

    void Update()
    {         // use spacebar as Next button
        if (allowSpace == true)
        {
            if (Input.GetKeyDown("space"))
            {
                talking();
            }
        }
    }

    //Story Units:
    public void talking()
    {         // main story function. Players hit next to progress to next int
        primeInt = primeInt + 1;
        if (primeInt == 1)
        {
            DialogueDisplay.SetActive(true);
            Char1name.text = ""; // Char 1 nimi
            Char1speech.text = ""; // Char 1 puhe

            Char2name.text = ""; // Char 2 nimi
            Char2speech.text = ""; // Char 2 puhe

            Char3name.text = ""; // Char 3 nimi
            Char3speech.text = ""; // Char 3 puhe

            Char4name.text = ""; // Char 4 nimi
            Char4speech.text = ""; // Char 4 puhe
        }
        else if (primeInt == 2)
        {
            Char1name.text = ""; // Char 1 nimi
            Char1speech.text = ""; // Char 1 puhe

            Char2name.text = ""; // Char 2 nimi
            Char2speech.text = ""; // Char 2 puhe

            Char3name.text = ""; // Char 3 nimi
            Char3speech.text = ""; // Char 3 puhe

            Char4name.text = ""; // Char 4 nimi
            Char4speech.text = "Monday, April 20th, 9:32 A.M.\r\nFront yard of a car dealership\r\n"; // Char 4 puhe
        }
        else if (primeInt == 3)
        {
            Char1name.text = ""; // Char 1 nimi
            Char1speech.text = ""; // Char 1 puhe

            Char2name.text = ""; // Char 2 nimi
            Char2speech.text = ""; // Char 2 puhe

            Char3name.text = "You"; // Char 3 nimi
            Char3speech.text = "(I found an ad for an R34 GT-R for an amazing price at this dealership)"; // Char 3 puhe

            Char4name.text = ""; // Char 4 nimi
            Char4speech.text = ""; // Char 4 puhe
        }
        else if (primeInt == 4)
        {
            Char1name.text = ""; // Char 1 nimi
            Char1speech.text = ""; // Char 1 puhe

            Char2name.text = ""; // Char 2 nimi
            Char2speech.text = ""; // Char 2 puhe

            Char3name.text = "You"; // Char 3 nimi
            Char3speech.text = "(Man, I’ve been wanting one of these forever! I’ve been saving up every penny for my dream car and this is it.)"; // Char 3 puhe

            Char4name.text = ""; // Char 4 nimi
            Char4speech.text = ""; // Char 4 puhe
        }
        else if (primeInt == 5)
        {
            Char1name.text = ""; // Char 1 nimi
            Char1speech.text = ""; // Char 1 puhe

            Char2name.text = ""; // Char 2 nimi
            Char2speech.text = ""; // Char 2 puhe

            Char3name.text = "You"; // Char 3 nimi
            Char3speech.text = "(6-cylinder RB26 with twin turbos, tuned to 340 horsepowers, custom exhaust, ATTESA-ETS four-wheel-drive system and gorgeous looks, it’s a real weapon on streets!)"; // Char 3 puhe

            Char4name.text = ""; // Char 4 nimi
            Char4speech.text = ""; // Char 4 puhe
        }
        else if (primeInt == 6)
        {
            Char1name.text = ""; // Char 1 nimi
            Char1speech.text = ""; // Char 1 puhe

            Char2name.text = ""; // Char 2 nimi
            Char2speech.text = ""; // Char 2 puhe

            Char3name.text = "You"; // Char 3 nimi
            Char3speech.text = "(This’ll get me some girls!)"; // Char 3 puhe

            Char4name.text = ""; // Char 4 nimi
            Char4speech.text = ""; // Char 4 puhe
        }
        else if (primeInt == 7)
        {
            Char1name.text = ""; // Char 1 nimi
            Char1speech.text = ""; // Char 1 puhe

            Char2name.text = ""; // Char 2 nimi
            Char2speech.text = ""; // Char 2 puhe

            Char3name.text = "You"; // Char 3 nimi
            Char3speech.text = "(Well, at least I hope so…)"; // Char 3 puhe

            Char4name.text = ""; // Char 4 nimi
            Char4speech.text = ""; // Char 4 puhe
        }
        else if (primeInt == 8)
        {
            Char1name.text = ""; // Char 1 nimi
            Char1speech.text = ""; // Char 1 puhe

            Char2name.text = ""; // Char 2 nimi
            Char2speech.text = ""; // Char 2 puhe

            Char3name.text = ""; // Char 3 nimi
            Char3speech.text = ""; // Char 3 puhe

            Char4name.text = ""; // Char 4 nimi
            Char4speech.text = "…"; // Char 4 puhe
        }

        else if (primeInt == 9)
        {
            Char1name.text = ""; // Char 1 nimi
            Char1speech.text = ""; // Char 1 puhe

            Char2name.text = ""; // Char 2 nimi
            Char2speech.text = ""; // Char 2 puhe

            Char3name.text = "You"; // Char 3 nimi
            Char3speech.text = "(Huh, I can’t seem to find the car anywhere.\r\nMaybe I should ask the owner of the dealership."; // Char 3 puhe

            Char4name.text = ""; // Char 4 nimi
            Char4speech.text = ""; // Char 4 puhe
        }
        else if (primeInt == 10)
        {
            ImageChar1.SetActive(true);
            Char1name.text = "Salesman"; // Char 1 nimi
            Char1speech.text = "Welcome! How may I help you?"; // Char 1 puhe

            Char2name.text = ""; // Char 2 nimi
            Char2speech.text = ""; // Char 2 puhe

            Char3name.text = ""; // Char 3 nimi
            Char3speech.text = ""; // Char 3 puhe

            Char4name.text = ""; // Char 4 nimi
            Char4speech.text = ""; // Char 4 puhe
        }

        else if (primeInt == 11)
        {
            ImageChar1.SetActive(false);
            Char1name.text = ""; // Char 1 nimi
            Char1speech.text = ""; // Char 1 puhe

            Char2name.text = ""; // Char 2 nimi
            Char2speech.text = ""; // Char 2 puhe

            Char3name.text = "You"; // Char 3 nimi
            Char3speech.text = "I saw an ad for an R34 GT-R for sale, is it still here?"; // Char 3 puhe

            Char4name.text = ""; // Char 4 nimi
            Char4speech.text = ""; // Char 4 puhe
        }
        else if (primeInt == 12)
        {
            ImageChar1.SetActive(true);
            Char1name.text = "Salesman"; // Char 1 nimi
            Char1speech.text = "Ah, you have a good eye! This car is stored at the backyard. Want to go and have a look at it?"; // Char 1 puhe

            Char2name.text = ""; // Char 2 nimi
            Char2speech.text = ""; // Char 2 puhe

            Char3name.text = ""; // Char 3 nimi
            Char3speech.text = ""; // Char 3 puhe

            Char4name.text = ""; // Char 4 nimi
            Char4speech.text = ""; // Char 4 puhe
        }
        else if (primeInt == 13)
        {
            ImageChar1.SetActive(false);
            Char1name.text = ""; // Char 1 nimi
            Char1speech.text = ""; // Char 1 puhe

            Char2name.text = ""; // Char 2 nimi
            Char2speech.text = ""; // Char 2 puhe

            Char3name.text = "You"; // Char 3 nimi
            Char3speech.text = "Sure."; // Char 3 puhe

            Char4name.text = ""; // Char 4 nimi
            Char4speech.text = ""; // Char 4 puhe
        }
        else if (primeInt == 14)
        {
            Char1name.text = ""; // Char 1 nimi
            Char1speech.text = ""; // Char 1 puhe

            Char2name.text = ""; // Char 2 nimi
            Char2speech.text = ""; // Char 2 puhe

            Char3name.text = ""; // Char 3 nimi
            Char3speech.text = ""; // Char 3 puhe

            Char4name.text = ""; // Char 4 nimi
            Char4speech.text = "The salesman starts walking behind the building. Once we get around the corner, I can see there’s plenty to choose from."; // Char 4 puhe
        }
        else if (primeInt == 15)
        {
            Char1name.text = ""; // Char 1 nimi
            Char1speech.text = ""; // Char 1 puhe

            Char2name.text = ""; // Char 2 nimi
            Char2speech.text = ""; // Char 2 puhe

            Char3name.text = ""; // Char 3 nimi
            Char3speech.text = ""; // Char 3 puhe

            Char4name.text = ""; // Char 4 nimi
            Char4speech.text = "From the corner of my eye, I can see a black and white racing car. It’s parked far-away from all the other cars…"; // Char 4 puhe
        }
        else if (primeInt == 16)
        {
            Char1name.text = ""; // Char 1 nimi
            Char1speech.text = ""; // Char 1 puhe

            Char2name.text = ""; // Char 2 nimi
            Char2speech.text = ""; // Char 2 puhe

            Char3name.text = "You"; // Char 3 nimi
            Char3speech.text = "What’s that car over there?"; // Char 3 puhe

            Char4name.text = ""; // Char 4 nimi
            Char4speech.text = ""; // Char 4 puhe
        }
        else if (primeInt == 17)
        {
            Char1name.text = ""; // Char 1 nimi
            Char1speech.text = ""; // Char 1 puhe

            Char2name.text = ""; // Char 2 nimi
            Char2speech.text = ""; // Char 2 puhe

            Char3name.text = ""; // Char 3 nimi
            Char3speech.text = "(Hmm... it’s like I’ve seen that car somewhere before.)";

            Char4name.text = ""; // Char 4 nimi
            Char4speech.text = ""; // Char 4 puhe
        }
        else if (primeInt == 18)
        {
            ImageChar1.SetActive(true);
            Char1name.text = "Salesman"; // Char 1 nimi
            Char1speech.text = "Oh that? It’s just an 86 we’ve been unable to sell. It has been neglected by the previous owner pretty badly, and it was sold to us for a very low price."; // Char 1 puhe

            Char2name.text = ""; // Char 2 nimi
            Char2speech.text = ""; // Char 2 puhe

            Char3name.text = ""; // Char 3 nimi
            Char3speech.text = ""; // Char 3 puhe

            Char4name.text = ""; // Char 4 nimi
            Char4speech.text = ""; // Char 4 puhe
        }
        else if (primeInt == 19)
        {
            ImageChar1.SetActive(false);
            Char1name.text = ""; // Char 1 nimi
            Char1speech.text = ""; // Char 1 puhe

            Char2name.text = ""; // Char 2 nimi
            Char2speech.text = ""; // Char 2 puhe

            Char3name.text = "You"; // Char 3 nimi
            Char3speech.text = "Ah, that’s pretty sad… But it’s in such a great condition, why you’ve been unable to sell it?"; // Char 3 puhe

            Char4name.text = ""; // Char 4 nimi
            Char4speech.text = ""; // Char 4 puhe
        }
        else if (primeInt == 20)
        {
            ImageChar1.SetActive(true);
            Char1name.text = "Salesman"; // Char 1 nimi
            Char1speech.text = "Well… I’m not superstitious, but…"; // Char 1 puhe

            Char2name.text = ""; // Char 2 nimi
            Char2speech.text = ""; // Char 2 puhe

            Char3name.text = ""; // Char 3 nimi
            Char3speech.text = ""; // Char 3 puhe

            Char4name.text = ""; // Char 4 nimi
            Char4speech.text = ""; // Char 4 puhe
        }
        else if (primeInt == 21)
        {
            ImageChar1.SetActive(false);
            Char1name.text = ""; // Char 1 nimi
            Char1speech.text = ""; // Char 1 puhe

            Char2name.text = ""; // Char 2 nimi
            Char2speech.text = ""; // Char 2 puhe

            Char3name.text = "You"; // Char 3 nimi
            Char3speech.text = "But what?”"; // Char 3 puhe

            Char4name.text = ""; // Char 4 nimi
            Char4speech.text = ""; // Char 4 puhe
        }
        else if (primeInt == 22)
        {
            ImageChar1.SetActive(true);
            Char1name.text = "Salesman"; // Char 1 nimi
            Char1speech.text = "…There is a legend that this car is cursed."; // Char 1 puhe

            Char2name.text = ""; // Char 2 nimi
            Char2speech.text = ""; // Char 2 puhe

            Char3name.text = ""; // Char 3 nimi
            Char3speech.text = ""; // Char 3 puhe

            Char4name.text = ""; // Char 4 nimi
            Char4speech.text = ""; // Char 4 puhe
        }
        else if (primeInt == 23)
        {
            ImageChar1.SetActive(false);
            Char1name.text = ""; // Char 1 nimi
            Char1speech.text = ""; // Char 1 puhe

            Char2name.text = ""; // Char 2 nimi
            Char2speech.text = ""; // Char 2 puhe

            Char3name.text = "You"; // Char 3 nimi
            Char3speech.text = "Curse?"; // Char 3 puhe

            Char4name.text = ""; // Char 4 nimi
            Char4speech.text = ""; // Char 4 puhe
        }
        else if (primeInt == 24)
        {
            ImageChar1.SetActive(true);
            Char1name.text = "Salesman"; // Char 1 nimi
            Char1speech.text = "Yes, cursed. It has been said this car has its own spirit."; // Char 1 puhe

            Char2name.text = ""; // Char 2 nimi
            Char2speech.text = ""; // Char 2 puhe

            Char3name.text = ""; // Char 3 nimi
            Char3speech.text = ""; // Char 3 puhe

            Char4name.text = ""; // Char 4 nimi
            Char4speech.text = ""; // Char 4 puhe
        }
        else if (primeInt == 25)
        {
            Char1name.text = "Salesman"; // Char 1 nimi
            Char1speech.text = "Customers who’ve test driven this 86 have said that the car won’t really respond to you and it’s really dangerous to drive."; // Char 1 puhe

            Char2name.text = ""; // Char 2 nimi
            Char2speech.text = ""; // Char 2 puhe

            Char3name.text = ""; // Char 3 nimi
            Char3speech.text = ""; // Char 3 puhe

            Char4name.text = ""; // Char 4 nimi
            Char4speech.text = ""; // Char 4 puhe
        }
        else if (primeInt == 26)
        {
            ImageChar1.SetActive(false);
            Char1name.text = ""; // Char 1 nimi
            Char1speech.text = ""; // Char 1 puhe

            Char2name.text = ""; // Char 2 nimi
            Char2speech.text = ""; // Char 2 puhe

            Char3name.text = "You"; // Char 3 nimi
            Char3speech.text = "So why haven’t you gotten rid of it, sent it to the scrappers?"; // Char 3 puhe

            Char4name.text = ""; // Char 4 nimi
            Char4speech.text = ""; // Char 4 puhe
        }
        else if (primeInt == 27)
        {
            ImageChar1.SetActive(true);
            Char1name.text = "Salesman"; // Char 1 nimi
            Char1speech.text = "I don’t have the heart to do that. It’s a pretty nice car after all."; // Char 1 puhe

            Char2name.text = ""; // Char 2 nimi
            Char2speech.text = ""; // Char 2 puhe

            Char3name.text = ""; // Char 3 nimi
            Char3speech.text = ""; // Char 3 puhe

            Char4name.text = ""; // Char 4 nimi
            Char4speech.text = ""; // Char 4 puhe
        }
        else if (primeInt == 28)
        {
            ImageChar1.SetActive(false);
            Char1name.text = ""; // Char 1 nimi
            Char1speech.text = ""; // Char 1 puhe

            Char2name.text = ""; // Char 2 nimi
            Char2speech.text = ""; // Char 2 puhe

            Char3name.text = ""; // Char 3 nimi
            Char3speech.text = ""; // Char 3 puhe

            Char4name.text = "You"; // Char 4 nimi
            Char4speech.text = "(A car with a spirit, that’s odd.)"; // Char 4 puhe
        }
        else if (primeInt == 29)
        {
            Char1name.text = ""; // Char 1 nimi
            Char1speech.text = ""; // Char 1 puhe

            Char2name.text = ""; // Char 2 nimi
            Char2speech.text = ""; // Char 2 puhe

            Char3name.text = ""; // Char 3 nimi
            Char3speech.text = ""; // Char 3 puhe

            Char4name.text = "You"; // Char 4 nimi
            Char4speech.text = "(Many people have tried to tame its soul, but have been unable to do so.)"; // Char 4 puhe
        }
        else if (primeInt == 30)
        {
            Char1name.text = ""; // Char 1 nimi
            Char1speech.text = ""; // Char 1 puhe

            Char2name.text = ""; // Char 2 nimi
            Char2speech.text = ""; // Char 2 puhe

            Char3name.text = ""; // Char 3 nimi
            Char3speech.text = ""; // Char 3 puhe

            Char4name.text = "You"; // Char 4 nimi
            Char4speech.text = "(Maybe… the car wants to choose its owner?)"; // Char 4 puhe
        }
        else if (primeInt == 31)
        {
            Char1name.text = ""; // Char 1 nimi
            Char1speech.text = ""; // Char 1 puhe

            Char2name.text = ""; // Char 2 nimi
            Char2speech.text = ""; // Char 2 puhe

            Char3name.text = ""; // Char 3 nimi
            Char3speech.text = ""; // Char 3 puhe

            Char4name.text = "You"; // Char 4 nimi
            Char4speech.text = "(Huh… maybe… maybe I’ll have a chance with it.)"; // Char 4 puhe
        }
        else if (primeInt == 32)
        {
            Char1name.text = ""; // Char 1 nimi
            Char1speech.text = ""; // Char 1 puhe

            Char2name.text = ""; // Char 2 nimi
            Char2speech.text = ""; // Char 2 puhe

            Char3name.text = ""; // Char 3 nimi
            Char3speech.text = ""; // Char 3 puhe

            Char4name.text = "You"; // Char 4 nimi
            Char4speech.text = "(I don’t know why, but it feels I know this car.)"; // Char 4 puhe
        }
        else if (primeInt == 33)
        {
            Char1name.text = ""; // Char 1 nimi
            Char1speech.text = ""; // Char 1 puhe

            Char2name.text = ""; // Char 2 nimi
            Char2speech.text = ""; // Char 2 puhe

            Char3name.text = "You"; // Char 3 nimi
            Char3speech.text = "Uh… does this car run? Can I have a test drive with it?"; // Char 3 puhe

            Char4name.text = ""; // Char 4 nimi
            Char4speech.text = ""; // Char 4 puhe
        }
        else if (primeInt == 34)
        {
            ImageChar1.SetActive(true);
            Char1name.text = "Salesman"; // Char 1 nimi
            Char1speech.text = "Huh, you’ve changed your mind on getting a proper sports car? Well, sure, you can have a go with it. But I’ll warn you, the car may kill you if you’re not careful."; // Char 1 puhe

            Char2name.text = ""; // Char 2 nimi
            Char2speech.text = ""; // Char 2 puhe

            Char3name.text = ""; // Char 3 nimi
            Char3speech.text = ""; // Char 3 puhe

            Char4name.text = ""; // Char 4 nimi
            Char4speech.text = ""; // Char 4 puhe
        }
        else if (primeInt == 35)
        {
            ImageChar1.SetActive(false);
            Char1name.text = ""; // Char 1 nimi
            Char1speech.text = ""; // Char 1 puhe

            Char2name.text = ""; // Char 2 nimi
            Char2speech.text = ""; // Char 2 puhe

            Char3name.text = "You"; // Char 3 nimi
            Char3speech.text = "It’s alright, I’ll take my chances."; // Char 3 puhe

            Char4name.text = ""; // Char 4 nimi
            Char4speech.text = ""; // Char 4 puhe
        }
        else if (primeInt == 36)
        {
            Char1name.text = ""; // Char 1 nimi
            Char1speech.text = ""; // Char 1 puhe

            Char2name.text = ""; // Char 2 nimi
            Char2speech.text = ""; // Char 2 puhe

            Char3name.text = ""; // Char 3 nimi
            Char3speech.text = ""; // Char 3 puhe

            Char4name.text = ""; // Char 4 nimi
            Char4speech.text = "The salesman gives me the keys but stays behind as if scared something may happen if he gets too close. I’m not scared of spirits, and if this car has one, maybe I’d be able to win it over."; // Char 4 puhe
        }
        else if (primeInt == 37)
        {
            Char1name.text = ""; // Char 1 nimi
            Char1speech.text = ""; // Char 1 puhe

            Char2name.text = ""; // Char 2 nimi
            Char2speech.text = ""; // Char 2 puhe

            Char3name.text = ""; // Char 3 nimi
            Char3speech.text = ""; // Char 3 puhe

            Char4name.text = ""; // Char 4 nimi
            Char4speech.text = "I walk to the car, other than couple old leaves on the windshield, it seems to be in excellent shape. No visible scratches on the paint job, clean mirrors, and windows. It’s a beauty."; // Char 4 puhe
        }
        else if (primeInt == 38)
        {
            Char1name.text = ""; // Char 1 nimi
            Char1speech.text = ""; // Char 1 puhe

            Char2name.text = ""; // Char 2 nimi
            Char2speech.text = ""; // Char 2 puhe

            Char3name.text = "You"; // Char 3 nimi
            Char3speech.text = "(Why would someone want to get rid of this…)"; // Char 3 puhe

            Char4name.text = ""; // Char 4 nimi
            Char4speech.text = ""; // Char 4 puhe
        }
        else if (primeInt == 39)
        {
            Char1name.text = ""; // Char 1 nimi
            Char1speech.text = ""; // Char 1 puhe

            Char2name.text = "?"; // Char 2 nimi
            Char2speech.text = "Hi, I’m Rokukyuu. Nice to meet you."; // Char 2 puhe

            Char3name.text = ""; // Char 3 nimi
            Char3speech.text = ""; // Char 3 puhe

            Char4name.text = ""; // Char 4 nimi
            Char4speech.text = ""; // Char 4 puhe
        }
        else if (primeInt == 40)
        {
            Char1name.text = ""; // Char 1 nimi
            Char1speech.text = ""; // Char 1 puhe

            Char2name.text = ""; // Char 2 nimi
            Char2speech.text = ""; // Char 2 puhe

            Char3name.text = ""; // Char 3 nimi
            Char3speech.text = ""; // Char 3 puhe

            Char4name.text = ""; // Char 4 nimi
            Char4speech.text = "I turn my head around to see the woman talking to me, but there’s nobody besides the same old salesman, who is standing over 10 meters away. I try to scan my surroundings to find who this mysterious voice belongs to-"; // Char 4 puhe
        }
        else if (primeInt == 41)
        {
            Char1name.text = ""; // Char 1 nimi
            Char1speech.text = ""; // Char 1 puhe

            Char2name.text = "Rokukyuu"; // Char 2 nimi
            Char2speech.text = "Wrong direction, silly. On your left. Lower."; // Char 2 puhe

            Char3name.text = ""; // Char 3 nimi
            Char3speech.text = ""; // Char 3 puhe

            Char4name.text = ""; // Char 4 nimi
            Char4speech.text = ""; // Char 4 puhe
        }
        else if (primeInt == 42)
        {
            ImageChar2.SetActive(true);
            Char1name.text = ""; // Char 1 nimi
            Char1speech.text = ""; // Char 1 puhe

            Char2name.text = "Rokukyuu"; // Char 2 nimi
            Char2speech.text = "There you go. Never talked to a lady before?"; // Char 2 puhe

            Char3name.text = ""; // Char 3 nimi
            Char3speech.text = ""; // Char 3 puhe

            Char4name.text = ""; // Char 4 nimi
            Char4speech.text = ""; // Char 4 puhe
        }
        else if (primeInt == 43)
        {
            ImageChar2.SetActive(false);
            Char1name.text = ""; // Char 1 nimi
            Char1speech.text = ""; // Char 1 puhe

            Char2name.text = ""; // Char 2 nimi
            Char2speech.text = ""; // Char 2 puhe

            Char3name.text = "You"; // Char 3 nimi
            Char3speech.text = "(The car talks. Speaks. Communicates. Have I gone mad…? Wait- did she make fun of me?!)"; // Char 3 puhe

            Char4name.text = ""; // Char 4 nimi
            Char4speech.text = ""; // Char 4 puhe
        }
        else if (primeInt == 44)
        {
            Char1name.text = ""; // Char 1 nimi
            Char1speech.text = ""; // Char 1 puhe

            Char2name.text = ""; // Char 2 nimi
            Char2speech.text = ""; // Char 2 puhe

            Char3name.text = "You"; // Char 3 nimi
            Char3speech.text = "Of course I’ve talked to girls before! Never to a one like yourself, so I was just surprised."; // Char 3 puhe

            Char4name.text = ""; // Char 4 nimi
            Char4speech.text = ""; // Char 4 puhe
        }
        else if (primeInt == 45)
        {
            ImageChar2.SetActive(true);
            Char1name.text = ""; // Char 1 nimi
            Char1speech.text = ""; // Char 1 puhe

            Char2name.text = ""; // Char 2 nimi
            Char2speech.text = ""; // Char 2 puhe

            Char3name.text = "Rokukyuu"; // Char 3 nimi
            Char3speech.text = "Yeah yeah, hot stuff. Care to tell your name?"; // Char 3 puhe

            Char4name.text = ""; // Char 4 nimi
            Char4speech.text = ""; // Char 4 puhe
        }
        else if (primeInt == 46)
        {
            ImageChar2.SetActive(false);
            Char1name.text = ""; // Char 1 nimi
            Char1speech.text = ""; // Char 1 puhe

            Char2name.text = ""; // Char 2 nimi
            Char2speech.text = ""; // Char 2 puhe

            Char3name.text = "You"; // Char 3 nimi
            Char3speech.text = "(She really is fucking with me.)"; // Char 3 puhe

            Char4name.text = ""; // Char 4 nimi
            Char4speech.text = ""; // Char 4 puhe
        }
        else if (primeInt == 47)
        {
            Char1name.text = ""; // Char 1 nimi
            Char1speech.text = ""; // Char 1 puhe

            Char2name.text = ""; // Char 2 nimi
            Char2speech.text = ""; // Char 2 puhe

            Char3name.text = "You"; // Char 3 nimi
            Char3speech.text = "Jesse. I'm Jesse."; // Char 3 puhe

            Char4name.text = ""; // Char 4 nimi
            Char4speech.text = ""; // Char 4 puhe
        }
        else if (primeInt == 48)
        {
            ImageChar2.SetActive(true);
            Char1name.text = ""; // Char 1 nimi
            Char1speech.text = ""; // Char 1 puhe

            Char2name.text = "Rokukyuu"; // Char 2 nimi
            Char2speech.text = "Nice name. Were you thinking to test drive me? Hop on and let’s go! Try to keep up with me."; // Char 2 puhe

            Char3name.text = ""; // Char 3 nimi
            Char3speech.text = ""; // Char 3 puhe

            Char4name.text = ""; // Char 4 nimi
            Char4speech.text = ""; // Char 4 puhe
        }
        else if (primeInt == 49)
        {
            ImageChar2.SetActive(false);
            Char1name.text = ""; // Char 1 nimi
            Char1speech.text = ""; // Char 1 puhe

            Char2name.text = ""; // Char 2 nimi
            Char2speech.text = ""; // Char 2 puhe

            Char3name.text = "You"; // Char 3 nimi
            Char3speech.text = "(She is cocky. But I’ve never failed at anything that involves driving. Like I’d let this be the first time.)"; // Char 3 puhe

            Char4name.text = ""; // Char 4 nimi
            Char4speech.text = ""; // Char 4 puhe
        }
        else if (primeInt == 50)
        {
            Char1name.text = ""; // Char 1 nimi
            Char1speech.text = ""; // Char 1 puhe

            Char2name.text = ""; // Char 2 nimi
            Char2speech.text = ""; // Char 2 puhe

            Char3name.text = "You"; // Char 3 nimi
            Char3speech.text = "Challenge accepted!"; // Char 3 puhe

            Char4name.text = ""; // Char 4 nimi
            Char4speech.text = ""; // Char 4 puhe
        }

    }
}