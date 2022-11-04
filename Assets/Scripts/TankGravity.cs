using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankGravity : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        if(transform.eulerAngles.z > 45)
        {
            transform.eulerAngles = new Vector3(0, 0, 45);
        }
        if (transform.eulerAngles.z < -45)
        {
            transform.eulerAngles = new Vector3(0, 0, -45);
        }

    }
}
