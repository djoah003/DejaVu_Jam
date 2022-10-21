using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CARmovement : MonoBehaviour
{
    public Rigidbody CARrb;
    public Transform car;
    public float speed = 17.0f;

    Vector3 rotationRight = new Vector3(0, 40, 0);
    Vector3 rotationLeft = new Vector3(0, -40, 0);

    Vector3 forward = new Vector3(0, 0, 1);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Auto liikkuu eteenp‰in vakionopeudella. Auto kiihtyy vakionopeuteen. A:sta ja D:sta k‰‰ntyy. 


         transform.Translate(Vector3.forward * speed * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            Quaternion deltaRotationRight = Quaternion.Euler(rotationRight * Time.deltaTime);
            CARrb.MoveRotation(CARrb.rotation * deltaRotationRight);
        }

        if (Input.GetKey("a"))
        {
            Quaternion deltaRotationLeft = Quaternion.Euler(rotationLeft * Time.deltaTime);
            CARrb.MoveRotation(CARrb.rotation * deltaRotationLeft);
        }
    }
}
