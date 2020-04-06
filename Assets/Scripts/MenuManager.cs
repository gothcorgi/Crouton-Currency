using System.Collections;
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
    public GameObject inventoryScissors;
    public bool wearScissors;
    public GameObject RedScissors;


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
            pc.moveSpeed = 8;
            pc.jumpSpeed = 18;
            RedScissors.SetActive(true);

        }
        if (wearScissors == false)
            {
            pc.moveSpeed = 5;
            pc.jumpSpeed = 10;
            RedScissors.SetActive(false);
        }

        if (goldCount >= 1 && ownScissors == false)
        {
            ShopScissors.interactable = true;
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

    }

    public void Reset()
    {
        PlayerPrefs.SetInt("Scissors", 0);
        inventoryScissors.SetActive(false);
        wearScissors = false; 
    }
}

