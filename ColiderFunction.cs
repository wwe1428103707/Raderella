using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mono;

public class ColiderFunction : MonoBehaviour {

    private static bool isCollision = false;
    private static bool isMouseCol = false;
    private static bool isAchieved = false;
    private bool MovingToDes = false;
    private Vector2 vector2;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.name);
        if (collision.GetComponent<Collider2D>().tag == "Player")
        {
            isCollision = true;
            Debug.Log(isCollision);
            this.gameObject.GetComponent<Animator>().SetBool("isHighLight",true);
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.GetComponent<Collider2D>().tag == "Player"&&Mathf.Abs(collision.GetComponent<Transform>().transform.position.x-this.gameObject.transform.position.x)<0.1)
        {
            MovingToDes = false;
            isAchieved = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log(collision.name);
        if (collision.GetComponent<Collider2D>().tag == "Player")
        {
            isAchieved = false;
            isCollision = false;
            Debug.Log(isCollision);
            this.gameObject.GetComponent<Animator>().SetBool("isHighLight",false);
        }
    }

    private void Update()
    {
        vector2 = Camera.main.ScreenToWorldPoint(Input.mousePosition)-this.gameObject.transform.position;
        if (isCollision == false)
        {
            if (Mathf.Abs(vector2.x) < 0.5 && Mathf.Abs(vector2.y) < 0.5)
            {
                if (Input.GetMouseButtonDown(0) && isAchieved==false)
                {
                    MovingToDes = true;
                }
                this.gameObject.GetComponent<Animator>().SetBool("isHighLight", true);
            }
            else
            {
                this.gameObject.GetComponent<Animator>().SetBool("isHighLight", false);
            }
        }

        if (GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>().GetisMoving() == false&&isAchieved==false&&MovingToDes == true)
        {
            GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>().transform.position = Vector2.MoveTowards(GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>().transform.position, new Vector2(this.gameObject.transform.position.x, GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>().transform.position.y), GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>().GetSpeed() * Time.deltaTime);
        }

        if (GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>().GetisMoving() == true)
        {
            MovingToDes = false;
        }
    }
}
