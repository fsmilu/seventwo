﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Endstory : MonoBehaviour {
    public GameObject p1,p2,p3,p4,p5,p6,p7,front,endlist;
	// Use this for initialization
	void Start () {

        DOTween.Sequence()
            .AppendInterval(4f).AppendCallback(() => { p1.transform.Find("mask").GetComponent<Shrinkshow>().trigger = true; })
            .AppendInterval(1f).AppendCallback(() => { p2.transform.Find("mask").GetComponent<Shrinkshow>().trigger = true; })
            .AppendInterval(2f).AppendCallback(() => { p3.transform.Find("mask").GetComponent<Shrinkshow>().trigger = true; })
            .AppendInterval(1f).AppendCallback(() => { p4.transform.Find("mask").GetComponent<Shrinkshow>().trigger = true; })
            .AppendInterval(2f).AppendCallback(() => { p5.transform.Find("mask").GetComponent<Shrinkshow>().trigger = true; })
            .AppendInterval(1f).AppendCallback(() => {
                p6.SetActive(true);
                p6.transform.Find("mask").GetComponent<Shrinkshow>().trigger = true; })
            .AppendInterval(2f).AppendCallback(() => { p7.transform.Find("mask").GetComponent<Shrinkshow>().trigger = true; })
            .AppendInterval(2f).Append(front.GetComponent<SpriteRenderer>().DOFade(1,2f))
            ;


    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnDestroy()
    {
        endlist.SetActive(true);
    }
}