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
}

