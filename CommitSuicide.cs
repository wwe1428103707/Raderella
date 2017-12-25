using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CommitSuicide : MonoBehaviour {
    private GameObject gameController;
    private bool isSuicide = false;
    private bool isSanToZero;
    float timecount = 0;
    String origintext;

    public void suicideFunction()
    {
        if (isSuicide)
        {
           /**
            try
            {
                this.gameObject.GetComponent<Text>().text = "自杀";
            }
            catch(Exception e)
            {
                this.gameObject.GetComponentInChildren<Text>().text = "自杀";
            }
            */
            Debug.Log("删档重来咯！");
        }
        else{
            /**
            try
            {
                this.gameObject.GetComponent<Text>().text = origintext;
            }
            catch(Exception e)
            {
                this.gameObject.GetComponentInChildren<Text>().text = origintext;
            }
            */
            Debug.Log("那你很棒棒哦！");
        }
    }

    private void Start()
    {
        try
        {
            gameController = GameObject.FindGameObjectWithTag("GameController");
        }
        catch(Exception e)
        {
            Debug.Log("No this GameObject");
        }

        try
        {
            origintext = this.gameObject.GetComponent<Text>().text;
        }
        catch(Exception e)
        {
            Debug.Log("There is not a Text");
            origintext = this.gameObject.GetComponentInChildren<Text>().text;
        }
        isSanToZero = gameController.GetComponent<GameController>().GetIsSanToZero();
    }

    private void Update()
    {
        isSanToZero = gameController.GetComponent<GameController>().GetIsSanToZero();
        if (isSanToZero == true) {
            timecount = timecount + Time.deltaTime;
            if (timecount > 0.5)
            {
                timecount = 0;
                float r = UnityEngine.Random.Range(0f, 4f);
                //Debug.Log(isSanToZero);
                //Debug.Log(r);
                if (r > 2)
                {
                    isSuicide = true;
                    try
                    {
                        this.gameObject.GetComponent<Text>().text = "自杀";
                    }
                    catch (Exception e)
                    {
                        this.gameObject.GetComponentInChildren<Text>().text = "自杀";
                    }
                    //Debug.Log(isSuicide);
                }
                else
                {
                    isSuicide = false;
                    try
                    {
                        this.gameObject.GetComponent<Text>().text = origintext;
                    }
                    catch (Exception e)
                    {
                        this.gameObject.GetComponentInChildren<Text>().text = origintext;
                    }
                    //Debug.Log(isSuicide);
                }
            }
        }
    }
}
