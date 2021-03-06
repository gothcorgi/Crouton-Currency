﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{

    public Animator simplenav;
    public Animator inventoryholder;
    public bool MenuOpen;


    public PlayerController pc;
    public int Scissors;
    public int Bread;
    public int SafeZone;
    public GameObject inventoryScissors;
    public GameObject inventoryBread;
    public GameObject inventorySafe;
    public bool wearScissors;
    public bool wearBread;
    public bool wearSafeZone;
    public GameObject RedScissors;
    public GameObject FakeBread;
    public GameObject TheSafeZone;


    public int goldCount;
    public Text goldText;


    public Button ShopScissors;
    public Button ShopBread;
    public Button ShopHide;

    public bool ownScissors;
    public bool ownBread;
    public bool ownHide;

    // Start is called before the first frame update
    void Start()
    {
        goldCount = PlayerPrefs.GetInt("Gold");
    }

    void Update()
    {

        PlayerPrefs.SetInt("Gold", goldCount);

        goldText.text = "Gold:" + goldCount;
        Scissors = PlayerPrefs.GetInt("Scissors");

        if (Scissors == 1)
        {
            inventoryScissors.SetActive(true);
        }

        if (wearScissors == true)
        {
            //pc.moveSpeed = 8;
            //pc.jumpSpeed = 18;
            RedScissors.SetActive(true);

        }
        if (wearScissors == false)
            {
            //pc.moveSpeed = 5;
            //pc.jumpSpeed = 10;
            RedScissors.SetActive(false);
        }

        if (goldCount >= 1 && ownScissors == false)
        {
            ShopScissors.interactable = true;
        }

        PlayerPrefs.SetInt("Gold", goldCount);

        goldText.text = "Gold:" + goldCount;
        SafeZone = PlayerPrefs.GetInt("SafeZone");

        if (SafeZone == 1)
        {
            inventorySafe.SetActive(true);
        }

        if (wearSafeZone == true)
        {
            //pc.moveSpeed = 8;
            //pc.jumpSpeed = 18;
            TheSafeZone.SetActive(true);

        }
        if (wearSafeZone == false)
        {
            //pc.moveSpeed = 5;
            //pc.jumpSpeed = 10;
            TheSafeZone.SetActive(false);
        }

        if (goldCount >= 1 && ownHide == false)
        {
            ShopHide.interactable = true;
        }

        PlayerPrefs.SetInt("Gold", goldCount);

        goldText.text = "Gold:" + goldCount;
        Bread = PlayerPrefs.GetInt("Fake Bread");

        if (Bread == 1)
        {
            inventoryBread.SetActive(true);
        }

        if (wearBread == true)
        {
            //pc.moveSpeed = 8;
            //pc.jumpSpeed = 18;
            FakeBread.SetActive(true);

        }
        if (wearBread == false)
        {
            //pc.moveSpeed = 5;
            //pc.jumpSpeed = 10;
            FakeBread.SetActive(false);
        }

        if (goldCount >= 1 && ownBread == false)
        {
            ShopBread.interactable = true;
        }
    }


    public void OpenNav()
    {
        if (MenuOpen == false)
        {
            simplenav.SetBool("Open", true);
            Time.timeScale = 0;
            MenuOpen = false;
        }

        else if (MenuOpen == true)
        {
            simplenav.SetBool("Open", false);
            Time.timeScale = 1;
            MenuOpen = false;
        }

    }

    public void ClosedNav()
    {
        simplenav.SetBool("Open", false);
        Time.timeScale = 1;
        MenuOpen = false;
    }

    public void OpenInv()
    {
        inventoryholder.SetBool("Open", true);
    }

    public void CloseInv()
    {
        inventoryholder.SetBool("Open", false);
    }

    public void BuyScissors()
    {
        goldCount -= 1;
        PlayerPrefs.SetInt("Scissors", 1);
        ShopScissors.interactable = false;
        ownScissors = true; 
    }

    public void PutOnScissors()
    {
        wearScissors = true;
        ownScissors = false;

    }

    public void BuyBread()
    {
        goldCount -= 1;
        PlayerPrefs.SetInt("Fake Bread", 1);
        ShopBread.interactable = false;
        ownBread = true;
    }

    public void PutOnBread()
    {
        wearBread = true;
        ownBread = false;

    }

    public void BuySafeZone()
    {
        goldCount -= 1;
        PlayerPrefs.SetInt("SafeZone", 1);
        ShopHide.interactable = false;
        ownHide = true;
    }

    public void PutOnSafeZone()
    {
        wearSafeZone = true;
        ownHide = false;

    }

    public void Reset()
    {
        PlayerPrefs.SetInt("Scissors", 0);
        inventoryScissors.SetActive(false);
        wearScissors = false; 
    }
}

