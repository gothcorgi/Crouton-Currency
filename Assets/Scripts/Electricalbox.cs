using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Electricalbox : MonoBehaviour
{
    public Animator myanim;
    public GameObject securityCam;
    public GameObject scissors; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "scissors")
        {
            myanim.SetBool("cut", true);
            scissors.SetActive(false);
            securityCam.SetActive(false);
            StartCoroutine("TempCut"); 
        }
    }

    IEnumerator TempCut()
    {
        securityCam.SetActive(false);
        myanim.SetBool("cut", true);
        yield return new WaitForSeconds(5f);
        securityCam.SetActive(true);
        myanim.SetBool("cut", false); 
    }
}
