using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class safeplacer : MonoBehaviour
{
    public GameObject safezone;

  public void PlaceSafe()
    {

        Instantiate(safezone, this.transform.position, this.transform.rotation); 

    }


}
