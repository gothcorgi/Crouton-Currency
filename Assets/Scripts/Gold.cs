using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gold : MonoBehaviour
{
    public MenuManager mm;
    public AudioSource pickupsound;
    public int goldValue; 

    // Start is called before the first frame update
    void Start()
    {
        mm = GameObject.FindObjectOfType<MenuManager>(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            mm.goldCount += (goldValue);
            pickupsound.Play(); 
            this.gameObject.SetActive(false);
        }
    }
}
