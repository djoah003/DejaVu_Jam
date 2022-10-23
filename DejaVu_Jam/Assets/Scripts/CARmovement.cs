using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CARmovement : MonoBehaviour
{

    public Rigidbody CARrb;
    public Transform car;
    public bool L = false, CL = true, CR = false, R = false;
    public float speed = 17.0f;

    Vector3 rotationRight = new Vector3(0, 40, 0);
    Vector3 rotationLeft = new Vector3(0, -40, 0);

    public GameObject KaistaL, KaistaCL, KaistaCR, KaistaR;
    public float x;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    private void Update()
    {
        //KaistaL.transform.Translate(new Vector3(0, 0, speed) * Time.deltaTime);
        //KaistaCL.transform.Translate(new Vector3(0, 0, speed) * Time.deltaTime);
        //KaistaCR.transform.Translate(new Vector3(0, 0, speed) * Time.deltaTime);
        //KaistaR.transform.Translate(new Vector3(0, 0, speed) * Time.deltaTime);
        //if(Input.GetKey("a"))
        //{
        //Quaternion deltaRotationLeft = Quaternion.Euler(rotationLeft * Time.deltaTime);
        //CARrb.MoveRotation(CARrb.rotation * deltaRotationLeft);
        //}
        //if(Input.GetKey("d"))
        //{
        //    Quaternion deltaRotationRight = Quaternion.Euler(rotationRight * Time.deltaTime);
        //    CARrb.MoveRotation(CARrb.rotation * deltaRotationRight);
        //}
        // Marraskuun homma: Kun vaihtaa kaistaa, niin auto k‰‰ntyy ja palaa suoraksi vaihdettua kaistan.
        KaistanVaihto();
    }
    
    void KaistanVaihto()
    {
        if (L)
        {
            this.gameObject.transform.position = KaistaL.transform.position;
            if (Input.GetKeyDown("d"))
            {
                this.gameObject.transform.position = KaistaCL.transform.position;
                L = false;
                CL = true;

            }
        }
        else if (CL)
        {
            this.gameObject.transform.position = KaistaCL.transform.position;
            if (Input.GetKeyDown("a"))
            {
                this.gameObject.transform.position = KaistaL.transform.position;
                CL = false;
                L = true;
            }
            if (Input.GetKeyDown("d"))
            {
                this.gameObject.transform.position = KaistaCR.transform.position;
                CL = false;
                CR = true;
            }
        }
        else if (CR)
        {
            this.gameObject.transform.position = KaistaCR.transform.position;
            if (Input.GetKeyDown("a"))
            {
                this.gameObject.transform.position = KaistaCL.transform.position;
                CR = false;
                CL = true;
            }
            if (Input.GetKeyDown("d"))
            {
                this.gameObject.transform.position = KaistaR.transform.position;
                CR = false;
                R = true;
            }
        }
        else if (R)
        {
            this.gameObject.transform.position = KaistaR.transform.position;
            if (Input.GetKeyDown("a"))
            {
                this.gameObject.transform.position = KaistaCR.transform.position;
                R = false;
                CR = true;
            }
        }
    }

}
    //Quaternion deltaRotationLeft = Quaternion.Euler(rotationLeft * Time.deltaTime);
    //CARrb.MoveRotation(CARrb.rotation* deltaRotationLeft);
