using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankController : MonoBehaviour
{
    public int PlayerNumber;
    public float moveSpeed;
    [SerializeField]
    Transform barrelRotator;
    [SerializeField]
    Transform firePoint;
    [SerializeField]
    GameObject bulletToFire;
    [SerializeField]
    Material actiefMat;
    [SerializeField]
    Material inactiefMat;
    bool isAanDeBeurt = false;
    float ShotPower = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isAanDeBeurt == true)
        {
            if (Input.GetKeyDown(KeyCode.Space)&& isAanDeBeurt == true)
            {
                Invoke("WisselBeurt", 0.1f);
            }
            if (PlayerNumber == 1)
            {
                barrelRotator.RotateAround(Vector3.forward, Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime);
            }
            if (PlayerNumber == 2)
            {
                barrelRotator.RotateAround(Vector3.forward, Input.GetAxis("Vertical") * moveSpeed * -Time.deltaTime);
            }
            if (Input.GetKeyDown(KeyCode.Space))
            {
                GameObject b = Instantiate(bulletToFire, firePoint.position, firePoint.rotation);
                if (PlayerNumber == 1)
                {
                    b.GetComponent<Rigidbody2D>().AddForce(barrelRotator.right * ShotPower, ForceMode2D.Impulse);
                }
                if (PlayerNumber == 2)
                {
                    b.GetComponent<Rigidbody2D>().AddForce(barrelRotator.right * -ShotPower, ForceMode2D.Impulse);
                }


            }
            if (PlayerNumber == 1) { }

            transform.Translate(Vector2.right * Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime);

            if (Input.GetKeyDown(KeyCode.E))
            {
                IncreasePower();
            }
            if (Input.GetKeyDown(KeyCode.Q))
            {
                DecreasePower();
            }
        }

    }

    void WisselBeurt()
    {
        GameObject.Find("TurnManager").GetComponent<TurnEngine>().WisselBeurt();
    }

    public void ZetActief(bool b)
    {
        if(b == true)
        {
            isAanDeBeurt = true;    
        }
        else
        {
            isAanDeBeurt = false;
        }
    }

    public void IncreasePower()
    {
        ShotPower++;
    }

    public void DecreasePower()
    {
        ShotPower--;
    }
}
