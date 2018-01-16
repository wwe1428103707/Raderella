using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RPGTALK.Localization;
//using RPGTALK;
using System.Collections;

public class RPGTalkButtonController : MonoBehaviour {

    public RPGTalk rpgtalk;

	// Use this for initialization
	void Start () {
        rpgtalk.OnMadeChoice += OnMadeChoice;
	}

    void OnMadeChoice(int questionId, int choiceID)
    {
        if (choiceID == 0 && questionId == 0)
        {
            rpgtalk.NewTalk("question_0_start", "question_0_end");
            Debug.Log("SAN值减1");
        }
    }
}
