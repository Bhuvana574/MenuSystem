using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MenuController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject optionalpanel;
    public GameObject toppanel, middlepanel;
    public void OptionalMenu()
    {
        optionalpanel.SetActive(true);
        toppanel.SetActive(false);
        middlepanel.SetActive(false);
    }

    // Update is called once per frame
    public void BackPanel()
    {
        optionalpanel.SetActive(false);
        toppanel.SetActive(true);
        middlepanel.SetActive(true);
    }
}
