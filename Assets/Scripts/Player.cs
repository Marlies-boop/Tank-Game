using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int spelerNummer;
    bool isAanDeBeurt = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isAanDeBeurt == true)
        {
         //   Invoke("WisselBeurt", 0.1f);
        }
    }
    /*void WisselBeurt()
    {
        GameObject.Find("TurnManager").GetComponent<TurnEngine>().WisselBeurt();
    }*/

    public void enabled(bool b)
    {
        if (b == true)
        {
            isAanDeBeurt = true;

        }
        else
        {
            isAanDeBeurt = false;

        }
    }

}