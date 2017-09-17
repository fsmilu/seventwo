﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour {

    public Player player;
    
    private void Update() {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            FindObjectOfType<ExitTrigger>().GetComponent<ExitTrigger>().enabled = true;
        }
        if (Input.GetKeyDown(KeyCode.F)) {
            FindObjectOfType<FullscreenTrigger>().GetComponent<FullscreenTrigger>().enabled = true;
        }

        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W)) {
            player.Go(Vector2.up);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S)) {
            player.Go(Vector2.down);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A)) {
            player.Go(Vector2.left);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D)) {
            player.Go(Vector2.right);
        }

    }
}