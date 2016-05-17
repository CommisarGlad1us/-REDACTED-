using UnityEngine;
using System.Collections;

public class MainMenuScript : MonoBehaviour {

    public GameObject[] menus;

    void start()
    {
        foreach (GameObject g in menus)
        {
            g.SetActive(false);
        }
    }

	public void OpenMenu (int i)

    {
        foreach (GameObject g in menus)
        {
            g.SetActive(false);
        }
        menus[i].SetActive(true);
    }
}
