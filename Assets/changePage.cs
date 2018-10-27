using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changePage : MonoBehaviour {

    public GameObject page1;
    public GameObject page2;

    private bool page = true;

    public void changepage()
    {
        if(page == true)
        {
            page = false;
            page2.SetActive(true);
            page1.SetActive(false);
        }
        else
        {
            page = true;
            page1.SetActive(true);
            page2.SetActive(false);
        }
    }
}
