using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Cardealershipcon : MonoBehaviour
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
            Char4speech.text = "Test drive is over, and I get out of Rokukyuu. I feel overwhelmed. What is this feeling?"; // Char 4 puhe
        }
        else if (primeInt == 3)
        {
            Char1name.text = ""; // Char 1 nimi
            Char1speech.text = ""; // Char 1 puhe

            Char2name.text = ""; // Char 2 nimi
            Char2speech.text = ""; // Char 2 puhe

            Char3name.text = "You"; // Char 3 nimi
            Char3speech.text = "And they say you’d be too difficult to handle. Was that the best you’ve got"; // Char 3 puhe

            Char4name.text = ""; // Char 4 nimi
            Char4speech.text = ""; // Char 4 puhe
        }
        else if (primeInt == 4)
        {
            ImageChar2.SetActive(true);
            Char1name.text = ""; // Char 1 nimi
            Char1speech.text = ""; // Char 1 puhe

            Char2name.text = "Rokukyuu"; // Char 2 nimi
            Char2speech.text = "You’ve only gotten a small taste, wait until you really see how fast I’m able to go. Round two?"; // Char 2 puhe

            Char3name.text = ""; // Char 3 nimi
            Char3speech.text = ""; // Char 3 puhe

            Char4name.text = ""; // Char 4 nimi
            Char4speech.text = ""; // Char 4 puhe
        }
        else if (primeInt == 5)
        {
            ImageChar2.SetActive(false);
            Char1name.text = ""; // Char 1 nimi
            Char1speech.text = ""; // Char 1 puhe

            Char2name.text = ""; // Char 2 nimi
            Char2speech.text = ""; // Char 2 puhe

            Char3name.text = "You"; // Char 3 nimi
            Char3speech.text = "Only if you promise to go faster"; // Char 3 puhe

            Char4name.text = ""; // Char 4 nimi
            Char4speech.text = ""; // Char 4 puhe
        }
        else if (primeInt == 6)
        {
            ImageChar2.SetActive(true);
            Char1name.text = ""; // Char 1 nimi
            Char1speech.text = ""; // Char 1 puhe

            Char2name.text = "Rokukyuu"; // Char 2 nimi
            Char2speech.text = "If you don’t scream, we’re not going fast enough."; // Char 2 puhe

            Char3name.text = ""; // Char 3 nimi
            Char3speech.text = ""; // Char 3 puhe

            Char4name.text = ""; // Char 4 nimi
            Char4speech.text = ""; // Char 4 puhe
        }
        else if (primeInt == 7)
        {
            ImageChar2.SetActive(false);
            Char1name.text = ""; // Char 1 nimi
            Char1speech.text = ""; // Char 1 puhe

            Char2name.text = ""; // Char 2 nimi
            Char2speech.text = ""; // Char 2 puhe

            Char3name.text = "You"; // Char 3 nimi
            Char3speech.text = "That’s a deal."; // Char 3 puhe

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
            Char4speech.text = "I can feel eyes on my back. I turn around and see the salesman staring me down, his lips are pursed together. He must think I’m some crazy person talking here all by myself."; // Char 4 puhe
        }
        else if (primeInt == 9)
        {
            Char1name.text = ""; // Char 1 nimi
            Char1speech.text = ""; // Char 1 puhe

            Char2name.text = ""; // Char 2 nimi
            Char2speech.text = ""; // Char 2 puhe

            Char3name.text = "You"; // Char 3 nimi
            Char3speech.text = "I think I’ve gotta go talk to the dealer before he calls the cops."; // Char 3 puhe

            Char4name.text = ""; // Char 4 nimi
            Char4speech.text = ""; // Char 4 puhe
        }
        else if (primeInt == 10)
        {
            ImageChar2.SetActive(true);
            Char1name.text = ""; // Char 1 nimi
            Char1speech.text = ""; // Char 1 puhe

            Char2name.text = "Rokukyuu"; // Char 2 nimi
            Char2speech.text = "Okay. Better sign those papers and take me home. It’s really boring to just hang out here doing nothing."; // Char 2 puhe

            Char3name.text = ""; // Char 3 nimi
            Char3speech.text = ""; // Char 3 puhe

            Char4name.text = ""; // Char 4 nimi
            Char4speech.text = ""; // Char 4 puhe
        }
        else if (primeInt == 11)
        {
            ImageChar2.SetActive(false);
            Char1name.text = ""; // Char 1 nimi
            Char1speech.text = ""; // Char 1 puhe

            Char2name.text = ""; // Char 2 nimi
            Char2speech.text = ""; // Char 2 puhe

            Char3name.text = "You"; // Char 3 nimi
            Char3speech.text = "I’ll see what I can do about that, Rokukyuu"; // Char 3 puhe

            Char4name.text = ""; // Char 4 nimi
            Char4speech.text = ""; // Char 4 puhe
        }
        else if (primeInt == 12)
        {
            ImageChar2.SetActive(true);
            Char1name.text = ""; // Char 1 nimi
            Char1speech.text = ""; // Char 1 puhe

            Char2name.text = "Rokukyuu"; // Char 2 nimi
            Char2speech.text = "Just say Roku. That’s what everyone else calls me."; // Char 2 puhe

            Char3name.text = ""; // Char 3 nimi
            Char3speech.text = ""; // Char 3 puhe

            Char4name.text = ""; // Char 4 nimi
            Char4speech.text = ""; // Char 4 puhe
        }
        else if (primeInt == 13)
        {
            ImageChar2.SetActive(false);
            Char1name.text = ""; // Char 1 nimi
            Char1speech.text = ""; // Char 1 puhe

            Char2name.text = ""; // Char 2 nimi
            Char2speech.text = ""; // Char 2 puhe

            Char3name.text = "You"; // Char 3 nimi
            Char3speech.text = "Okay, Roku. Don’t drive off."; // Char 3 puhe

            Char4name.text = ""; // Char 4 nimi
            Char4speech.text = ""; // Char 4 puhe
        }
        else if (primeInt == 14)
        {
            ImageChar2.SetActive(true);
            Char1name.text = ""; // Char 1 nimi
            Char1speech.text = ""; // Char 1 puhe

            Char2name.text = "Rokukyuu"; // Char 2 nimi
            Char2speech.text = "Haha. Funny. Go."; // Char 2 puhe

            Char3name.text = ""; // Char 3 nimi
            Char3speech.text = ""; // Char 3 puhe

            Char4name.text = ""; // Char 4 nimi
            Char4speech.text = ""; // Char 4 puhe
        }
        else if (primeInt == 15)
        {
            ImageChar2.SetActive(false);
            Char1name.text = ""; // Char 1 nimi
            Char1speech.text = ""; // Char 1 puhe

            Char2name.text = ""; // Char 2 nimi
            Char2speech.text = ""; // Char 2 puhe

            Char3name.text = ""; // Char 3 nimi
            Char3speech.text = ""; // Char 3 puhe

            Char4name.text = ""; // Char 4 nimi
            Char4speech.text = "I give Roku a smirk and walk to the slightly terrified looking salesman."; // Char 4 puhe
        }
        else if (primeInt == 16)
        {
            ImageChar1.SetActive(true);
            Char1name.text = "Salesman"; // Char 1 nimi
            Char1speech.text = "What do think? Do you want to go and test that R34?"; // Char 1 puhe

            Char2name.text = ""; // Char 2 nimi
            Char2speech.text = ""; // Char 2 puhe

            Char3name.text = ""; // Char 3 nimi
            Char3speech.text = ""; // Char 3 puhe

            Char4name.text = ""; // Char 4 nimi
            Char4speech.text = ""; // Char 4 puhe
        }
        else if (primeInt == 17)
        {
            ImageChar1.SetActive(false);
            Char1name.text = ""; // Char 1 nimi
            Char1speech.text = ""; // Char 1 puhe

            Char2name.text = ""; // Char 2 nimi
            Char2speech.text = ""; // Char 2 puhe

            Char3name.text = "You"; // Char 3 nimi
            Char3speech.text = "No need. I take the 86."; // Char 3 puhe

            Char4name.text = ""; // Char 4 nimi
            Char4speech.text = ""; // Char 4 puhe
        }
        else if (primeInt == 18)
        {
            ImageChar1.SetActive(true);
            Char1name.text = "Salesman"; // Char 1 nimi
            Char1speech.text = "You what???"; // Char 1 puhe

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
            Char3speech.text = "I take the 86. Should we go inside and fill up the paperwork."; // Char 3 puhe

            Char4name.text = ""; // Char 4 nimi
            Char4speech.text = ""; // Char 4 puhe
        }
        else if (primeInt == 20)
        {
            ImageChar1.SetActive(true);
            Char1name.text = "Salesman"; // Char 1 nimi
            Char1speech.text = "Are you sure? You can’t return the car or sue us if something happens."; // Char 1 puhe

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
            Char3speech.text = "Are you sure? You can’t return the car or sue us if something happens."; // Char 3 puhe

            Char4name.text = ""; // Char 4 nimi
            Char4speech.text = ""; // Char 4 puhe
        }
        else if (primeInt == 22)
        {
            ImageChar1.SetActive(true);
            Char1name.text = "Salesman"; // Char 1 nimi
            Char1speech.text = "Her? You really are serious. I guess we should go then."; // Char 1 puhe

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

            Char3name.text = ""; // Char 3 nimi
            Char3speech.text = ""; // Char 3 puhe

            Char4name.text = ""; // Char 4 nimi
            Char4speech.text = "We walk inside the dealership and the salesman gives me fat stack of papers."; // Char 4 puhe
        }
        else if (primeInt == 24)
        {
            ImageChar1.SetActive(true);
            Char1name.text = "Salesman"; // Char 1 nimi
            Char1speech.text = "Sorry for all the paperwork. The car is special, and we just want to make sure you know what you’re getting into."; // Char 1 puhe

            Char2name.text = ""; // Char 2 nimi
            Char2speech.text = ""; // Char 2 puhe

            Char3name.text = ""; // Char 3 nimi
            Char3speech.text = ""; // Char 3 puhe

            Char4name.text = ""; // Char 4 nimi
            Char4speech.text = ""; // Char 4 puhe
        }
        else if (primeInt == 25)
        {
            Char1name.text = ""; // Char 1 nimi
            Char1speech.text = ""; // Char 1 puhe

            Char2name.text = ""; // Char 2 nimi
            Char2speech.text = ""; // Char 2 puhe

            Char3name.text = "You"; // Char 3 nimi
            Char3speech.text = "Understandable."; // Char 3 puhe

            Char4name.text = ""; // Char 4 nimi
            Char4speech.text = ""; // Char 4 puhe
        }
        else if (primeInt == 26)
        {
            Char1name.text = ""; // Char 1 nimi
            Char1speech.text = ""; // Char 1 puhe

            Char2name.text = ""; // Char 2 nimi
            Char2speech.text = ""; // Char 2 puhe

            Char3name.text = ""; // Char 3 nimi
            Char3speech.text = ""; // Char 3 puhe

            Char4name.text = ""; // Char 4 nimi
            Char4speech.text = "I skim through the papers. It’s as if I’m giving up my human rights. They really don’t want anything to do with the car after it leaves the place… "; // Char 4 puhe
        }

        else if (primeInt == 27)
        {
            Char1name.text = ""; // Char 1 nimi
            Char1speech.text = ""; // Char 1 puhe

            Char2name.text = ""; // Char 2 nimi
            Char2speech.text = ""; // Char 2 puhe

            Char3name.text = ""; // Char 3 nimi
            Char3speech.text = ""; // Char 3 puhe

            Char4name.text = ""; // Char 4 nimi
            Char4speech.text = "Yes, I accept her in the shape she is. No, I’m not going to file a lawsuit. No return policy… The dealership won’t cover exorcist cost for the customer…? Okay, I think they’re really gone overboard with this."; // Char 4 puhe
        }
        else if (primeInt == 28)
        {
            Char1name.text = ""; // Char 1 nimi
            Char1speech.text = ""; // Char 1 puhe

            Char2name.text = ""; // Char 2 nimi
            Char2speech.text = ""; // Char 2 puhe

            Char3name.text = ""; // Char 3 nimi
            Char3speech.text = ""; // Char 3 puhe

            Char4name.text = ""; // Char 4 nimi
            Char4speech.text = "I sing the papers, and hand them over to the salesman. He smiles and shakes my hand."; // Char 4 puhe
        }
        else if (primeInt == 29)
        {
            ImageChar1.SetActive(true);
            Char1name.text = "Salesman"; // Char 1 nimi
            Char1speech.text = "Now there’s just the payment and the car is yours."; // Char 1 puhe

            Char2name.text = ""; // Char 2 nimi
            Char2speech.text = ""; // Char 2 puhe

            Char3name.text = ""; // Char 3 nimi
            Char3speech.text = ""; // Char 3 puhe

            Char4name.text = ""; // Char 4 nimi
            Char4speech.text = ""; // Char 4 puhe
        }
        else if (primeInt == 30)
        {
            ImageChar1.SetActive(false);
            Char1name.text = ""; // Char 1 nimi
            Char1speech.text = ""; // Char 1 puhe

            Char2name.text = ""; // Char 2 nimi
            Char2speech.text = ""; // Char 2 puhe

            Char3name.text = ""; // Char 3 nimi
            Char3speech.text = ""; // Char 3 puhe

            Char4name.text = ""; // Char 4 nimi
            Char4speech.text = "Roku is basically free for how cheap the dealership is willing to sell her. Well, now I have more to fix her up with. Money changes owners and the man gives me the keys."; // Char 4 puhe
        }
        else if (primeInt == 31)
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
        else if (primeInt == 32)
        {
            Char1name.text = ""; // Char 1 nimi
            Char1speech.text = ""; // Char 1 puhe

            Char2name.text = ""; // Char 2 nimi
            Char2speech.text = ""; // Char 2 puhe

            Char3name.text = ""; // Char 3 nimi
            Char3speech.text = ""; // Char 3 puhe

            Char4name.text = ""; // Char 4 nimi
            Char4speech.text = "The weight of the keys feels just right. Familiar. This really was the right choice."; // Char 4 puhe
        }
        else if (primeInt == 33)
        {
            Char1name.text = ""; // Char 1 nimi
            Char1speech.text = ""; // Char 1 puhe

            Char2name.text = ""; // Char 2 nimi
            Char2speech.text = ""; // Char 2 puhe

            Char3name.text = "You"; // Char 3 nimi
            Char3speech.text = "Guess who’s back. Ready for round two?"; // Char 3 puhe

            Char4name.text = ""; // Char 4 nimi
            Char4speech.text = "…"; // Char 4 puhe
        }
        else if (primeInt == 34)
        {
            ImageChar2.SetActive(true);
            Char1name.text = ""; // Char 1 nimi
            Char1speech.text = ""; // Char 1 puhe

            Char2name.text = "Rokukyuu"; // Char 2 nimi
            Char2speech.text = "What are you waiting for. Step on the gas and let’s go."; // Char 2 puhe

            Char3name.text = ""; // Char 3 nimi
            Char3speech.text = ""; // Char 3 puhe

            Char4name.text = ""; // Char 4 nimi
            Char4speech.text = "…"; // Char 4 puhe
        }
        else if (primeInt == 35)
        {
            ImageChar2.SetActive(false);
            Char1name.text = ""; // Char 1 nimi
            Char1speech.text = ""; // Char 1 puhe

            Char2name.text = ""; // Char 2 nimi
            Char2speech.text = ""; // Char 2 puhe

            Char3name.text = ""; // Char 3 nimi
            Char3speech.text = ""; // Char 3 puhe

            Char4name.text = ""; // Char 4 nimi
            Char4speech.text = "…"; // Char 4 puhe
        }
        else if (primeInt == 35)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}