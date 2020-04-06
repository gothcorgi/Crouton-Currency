using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
public class SecurityDetection : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] seekers;
    public bool found;
    public Text exclamation; 
    void Start()
    {
        seekers = GameObject.FindGameObjectsWithTag("seeker"); 
    }

    // Update is called once per frame
    void Update()
    {
        if(found == true)
        {
            for(int i = 0; i < seekers.Length; i++)
            {
                seekers[i].GetComponent<FlyingEnemy>().playertarget = true; 
            }
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            found = true;
            exclamation.enabled = true; 
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        exclamation.enabled = false; 
    }
}
