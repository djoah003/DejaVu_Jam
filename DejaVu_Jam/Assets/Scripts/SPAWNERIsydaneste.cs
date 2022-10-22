using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SPAWNERIsydaneste : MonoBehaviour
{

    public GameObject este = null;
    public GameObject sydan = null;
    public GameObject spawner = null;
    public GameObject sivu = null;
    // RND left and right range
    public float xleft = 0;
    public float xright = 0;
    // The Z-coordinate where animals spawn.
    public float z = 0;
    public float y = 0;

    // CreateOne spawn one random enemy
    private void CreateOne()
    {
        // rnd = random number generator
        int rnd = Random.Range(0, 4);
        float x = Random.Range(xleft, xright);

        if (rnd <= 2)
            Instantiate(sydan, new Vector3(x, 0, z), sydan.transform.rotation);
        else
            Instantiate(este, new Vector3(x, 0, z), este.transform.rotation);


    }

    private void CreateSivu()
    {
        Instantiate(sivu, new Vector3(-25, 0, z), sivu.transform.rotation);
        Instantiate(sivu, new Vector3(25, 0, z), sivu.transform.rotation);
    }

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CreateOne", 5.0f, 1.0f);
        InvokeRepeating("CreateSivu", 1.0f, 1.0f);

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        z = z + (spawner.transform.position.z - z) * Time.deltaTime;
        y = spawner.transform.position.y;
    }
}
