using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseThisComponent : MonoBehaviour {
    public void closeComponet(GameObject gameObject)
    {
        if (GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>().GetIsSanToZero() == false)
        {
            gameObject.SetActive(false);
        }
    }

    public void openComponet(GameObject gameObject)
    {
        if (GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>().GetIsSanToZero() == false)
        {
            if (gameObject.active == false)
            {
                gameObject.SetActive(true);
            }
            else if (gameObject.active == true)
            {
                gameObject.SetActive(false);
            }
        }
    }
}
