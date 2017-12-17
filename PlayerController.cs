using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Mono
{
    public class PlayerController : MonoBehaviour
    {
     //   public GameObject bullet;
     //   public float bulletshootrate;

   //     private GameObject parentObject;
        private KeyCode left;
        private KeyCode right;
//        private KeyCode jump;
 //       private KeyCode squat;
//        private KeyCode shoot;
        private int speed_stand;
//        private int speed_squat;
        private int speed;
//        private int jumpforce;
        private Vector3 standscale = new Vector3(1, 1, 1);
 //       private Vector3 squatscale = new Vector3(1, 0.5f, 1);
        new private Rigidbody2D rigidbody2D;
//        private bool isOnAir;
//        private bool isCalmDown;

        private double _time;

        private bool isMoving = false;

        // Use this for initialization
        void Start()
        {
 //           parentObject = this.gameObject;
            GameObject gameObject = GameObject.FindGameObjectWithTag("GameController");
            left = gameObject.GetComponent<GameController>().playerLEFT;
            right = gameObject.GetComponent<GameController>().playerRIGHT;
  //          jump = gameObject.GetComponent<GameController>().playerUP;
   //         squat = gameObject.GetComponent<GameController>().playerDOWN;
            speed_stand = gameObject.GetComponent<GameController>().playerSPEED_STAND;
 //           speed_squat = gameObject.GetComponent<GameController>().playerSPEED_SQUAT;
            speed = speed_stand;
   //         jumpforce = gameObject.GetComponent<GameController>().playerJumpForce;
   //         shoot = gameObject.GetComponent<GameController>().playerSHOOT;
            rigidbody2D = GetComponent<Rigidbody2D>();
    //        isCalmDown = true;
     //       isOnAir = false;
            //bullet.GetComponent<BulletController>().parentObject = this.gameObject;
        }

        // Update is called once per frame
        void Update()
        {
            MoveFunction();
  //          JumpFunction();
   //         SquatFunction();
           // ShootFunction();
           /* _time = _time + Time.deltaTime;
            if (_time >= bulletshootrate)
            {
                isCalmDown = true;
            }*/
        }

        public float GetSpeed()
        {
            return speed;
        }

        public bool GetisMoving()
        {
            return isMoving;
        }

        public void SetisMoving(bool a)
        {
            isMoving = a;
        }

        private void MoveFunction()
        {
            if (Input.GetKey(left))
            {
                isMoving = true;
                rigidbody2D.velocity = new Vector2(-speed, rigidbody2D.velocity.y);
                standscale = new Vector3(-1, 1, 1);
  //              squatscale = new Vector3(-1, 0.5f, 1);
                transform.localScale = standscale;
            }
            if (Input.GetKey(right))
            {
                isMoving = true;
                rigidbody2D.velocity = new Vector2(speed, rigidbody2D.velocity.y);
//                squatscale = new Vector3(1, 0.5f, 1);
                standscale = new Vector3(1, 1, 1);
                transform.localScale = standscale;
            }
            if (Input.GetKeyUp(left) || Input.GetKeyUp(right))
            {
                isMoving = false;
                rigidbody2D.velocity = new Vector2(0, rigidbody2D.velocity.y);
            }
            if (Input.GetKey(left) && Input.GetKey(right))
            {
                isMoving = true;
                rigidbody2D.velocity = new Vector2(0, rigidbody2D.velocity.y);
            }
        }

 /*       private void JumpFunction()
        {
            if (Input.GetKeyDown(jump) && isOnAir == false)
            {
                isOnAir = true;
                rigidbody2D.velocity = new Vector2(rigidbody2D.velocity.x, jumpforce);
            }
            if (rigidbody2D.velocity.y == 0)
            {
                isOnAir = false;
            }
        }
*/
 /*       private void SquatFunction()
        {
            if (Input.GetKey(squat))
            {
                transform.localScale = squatscale;
                speed = speed_squat;
            }
            if (Input.GetKeyDown(squat))
            {
                transform.Translate(new Vector3(0, -squatscale.y / 2, 0));
            }
            if (Input.GetKeyUp(squat))
            {
                transform.localScale = standscale;
                speed = speed_stand;
                transform.Translate(new Vector3(0, squatscale.y / 2, 0));
            }
        }
 */
/*
        private void ShootFunction()
        {
            if (Input.GetKeyDown(shoot) && isCalmDown == true)
            {
                isCalmDown = false;
                _time = 0;
                GameObject.Instantiate(bullet, new Vector3(parentObject.transform.position.x, parentObject.transform.position.y), parentObject.transform.rotation);
            }
        }
*/
    }
}
