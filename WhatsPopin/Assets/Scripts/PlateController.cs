﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class PlateController : MonoBehaviour
{

    private GameManager gameMgr;

    private void Awake()
    {
        //get reference to the game manager using 'FindObjectOfType'
        gameMgr = FindObjectOfType<GameManager>();
    }

    /// <summary>
    /// Vibrate the controller when we pick up the ball
    /// </summary>
    public void OnBallPickedUp()
    {
        //get refernce to the active hand
        //then haptic impulse
        //next week
 
    }

    /// <summary>
    /// To be called from the 'Throwable' 
    /// script's "OnDetachFromHand()' event
    /// </summary>
    public void OnBallReleased()
    {
        //Set a timer of '5 seconds'.
        //If we don't hit the pins within this time,
        //then we assume the ball has gone astray
        //Reset and spawn a new ball for the next
        //try
        StartCoroutine(ResetAfterDelay());
    }

    IEnumerator ResetAfterDelay()
    {
        yield return new WaitForSeconds(3.0f);
        Destroy(gameObject); //destroy the gameObject

        gameMgr.ResetPosition();

    }
}
