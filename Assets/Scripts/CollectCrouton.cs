using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCrouton : MonoBehaviour
{
    public bool ownFake;
    public int fake;
    public Rigidbody2D cRB;
    public SpriteRenderer sr;
    public SpriteRenderer sr2;
    public GameObject securitycam; 
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("Fake", 1); 
    }

    // Update is called once per frame
    void Update()
    {
        fake = PlayerPrefs.GetInt("Fake"); 
        if(fake > 0)
        {
            ownFake = true; 
        }
        else
        {
            ownFake = false; 
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            if(ownFake == true)
            {
                sr.enabled = false;
                sr2.enabled = true;
                PlayerPrefs.SetInt("Fake", 0); 

            }

            else if (ownFake == false)
            {
                sr.enabled = false;
                cRB.mass = 1; 


            }
        }
    }

    //public void DisabledSecurity();
}
