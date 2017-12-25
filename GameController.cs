using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    public KeyCode playerUP = KeyCode.Space;
    public KeyCode playerDOWN = KeyCode.C;
    public KeyCode playerLEFT = KeyCode.LeftArrow;
    public KeyCode playerRIGHT = KeyCode.RightArrow;
    public KeyCode playerSHOOT = KeyCode.X;
    public int playerSPEED_STAND = 2;
    public int playerSPEED_SQUAT = 1;
    public float bulletSPEED = 5;
    public int playerJumpForce = 10; //M=1,G=10
    /// <summary>
    /// 这个san值会被修改为private,利用Get方法访问
    /// </summary>
    public int san = 100;
    //public float isSuicideChangeTime = 0;
    private bool isSanToZero = false;
    // Use this for initialization
    void Awake()
    {
        playerUP = KeyCode.Space;
        playerDOWN = KeyCode.C;
        playerLEFT = KeyCode.LeftArrow;
        playerRIGHT = KeyCode.RightArrow;
        playerSPEED_STAND = 2;
        playerSPEED_SQUAT = 1;
        Debug.Log(playerLEFT);
    }

    public void SetSan(int san)
    {
        this.san = san;
    }

    private void Update()
    {
        if(san <= 0)
        {
            isSanToZero = true;
        }
    }

    public bool GetIsSanToZero()
    {
        return isSanToZero;
    }
}

