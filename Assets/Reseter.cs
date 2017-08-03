﻿﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reseter : MonoBehaviour {
    public Section sectionNow;
    public Vector3 playerBegin;

	void Update () {
        if (reset) {
            Reset();
        }
	}
    public bool reset = false;
    public void Reset() {
        GameObject prefab = Resources.Load<GameObject>(sectionNow.prefabName);
        GameObject newOne = Instantiate(prefab, transform);
        newOne.SetActive(true);
        Destroy(sectionNow.gameObject);
        sectionNow = newOne.GetComponent<Section>();

        FindObjectOfType<Player>().transform.position = playerBegin;

        reset = false;
    }
}