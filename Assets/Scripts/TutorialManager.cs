using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CnControls;

public class TutorialManager : MonoBehaviour
{
    public GameObject[] popUps;
    private int popupIndex;
    public GameObject spawner;
    public float waitTime = 2f;
    public PlayerController player;

    private void Start()
    {
       // player.jumpForce = 0;
    }

    void Update()
    {
        for (int i = 0; i < popUps.Length; i++)
        {
            if (i == popupIndex)
            {
                popUps[i].SetActive(true); 
            }else
            {
                popUps[i].SetActive(false); 
            }
        }
        if (popupIndex == 0)
            if(Input.GetKeyDown(KeyCode.LeftArrow)|| Input.GetKeyDown(KeyCode.RightArrow))
            {
                popupIndex++; 
            }else if(popupIndex == 1)
            {
                if (CnInputManager.GetButtonDown("Jump"))
                {
                    //player.jumpForce = 8;
                    popupIndex++; 
                }else if (popupIndex == 2)
                {
                    if (waitTime <= 0)
                    {
                        spawner.SetActive(true);
                    }
                    else
                    {
                        waitTime -= Time.deltaTime;
                    }
                    
                }
            }
        
    }
}