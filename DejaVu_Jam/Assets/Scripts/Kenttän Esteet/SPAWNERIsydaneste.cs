using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SPAWNERIsydaneste : MonoBehaviour
{

    public GameObject este = null;
    public GameObject sydan = null;
    private PISTELASKURI Laskuri;
    public GameObject SpawnerL, SpawnerCL, SpawnerCR, SpawnerR;
    public float timeRemaining;
    public AudioSource EurobeatPlayer;

    // CreateOne spawn one random enemy
    private void CreateOne()
    {
        // rnd = random number generator
        int rndEste = Random.Range(1, 3);
        int spawner = Random.Range(1, 5);
        while (!EurobeatPlayer.isPlaying)
        {
            if (spawner == 1)
            {
                if (rndEste <= 1)
                {
                    Instantiate(sydan, new Vector3(SpawnerL.transform.position.x, SpawnerL.transform.position.y, SpawnerL.transform.position.z), sydan.transform.rotation);
                    Laskuri.x = Laskuri.x + 1;
                }
                else
                    Instantiate(este, new Vector3(SpawnerL.transform.position.x, SpawnerL.transform.position.y, SpawnerL.transform.position.z), este.transform.rotation);
            }
            if (spawner == 2)
            {
                if (rndEste <= 1)
                {
                    Instantiate(sydan, new Vector3(SpawnerCL.transform.position.x, SpawnerCL.transform.position.y, SpawnerCL.transform.position.z), sydan.transform.rotation);
                    Laskuri.x = Laskuri.x + 1;
                }
                else
                    Instantiate(este, new Vector3(SpawnerCL.transform.position.x, SpawnerCL.transform.position.y, SpawnerCL.transform.position.z), este.transform.rotation);
            }
            if (spawner == 3)
            {
                if (rndEste <= 1)
                {
                    Instantiate(sydan, new Vector3(SpawnerCR.transform.position.x, SpawnerCR.transform.position.y, SpawnerCR.transform.position.z), sydan.transform.rotation);
                    Laskuri.x = Laskuri.x + 1;
                }
                else
                    Instantiate(este, new Vector3(SpawnerCR.transform.position.x, SpawnerCR.transform.position.y, SpawnerCR.transform.position.z), este.transform.rotation);
            }
            if (spawner == 4)
            {
                if (rndEste <= 1)
                {
                    Instantiate(sydan, new Vector3(SpawnerR.transform.position.x, SpawnerR.transform.position.y, SpawnerR.transform.position.z), sydan.transform.rotation);
                    Laskuri.x = Laskuri.x + 1;
                }
                else
                    Instantiate(este, new Vector3(SpawnerR.transform.position.x, SpawnerR.transform.position.y, SpawnerR.transform.position.z), este.transform.rotation);
            }
        }
        Laskuri.HasEnded = true;
    }

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CreateOne", 5.0f, 1.0f);
        Laskuri = GameObject.Find("Laskuri").GetComponent<PISTELASKURI>();
    }
    void Update()
    {

    }
    // Update is called once per frame
}
