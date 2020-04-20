using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CnControls;

public class TutorialManager : MonoBehaviour
{
    public GameObject[] popUps;
    private int popupIndex;
    //public GameObject spawner;
    public float waitTime = 2f;
    public PlayerController player;
    public LeftJoystick LJ; 

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
        {
            if (LJ.inputVector.x != 0)
            {
                Debug.Log("joystickmoved");
                popupIndex++; 
            }

        }
        //if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.RightArrow))
       // {
          //  popupIndex++;
        //}
        else if (popupIndex == 1)
        {
            if (CnInputManager.GetButtonDown("Jump"))
            {
                Debug.Log("jumped");
                //player.jumpForce = 8;
                popupIndex++;
            }
        }
        else if (popupIndex == 2)
        {
            waitTime -= Time.deltaTime;
            if (waitTime <= 0)
            {
                popupIndex++; 
                //spawner.SetActive(true);
            }
            

        }
          
    }
}