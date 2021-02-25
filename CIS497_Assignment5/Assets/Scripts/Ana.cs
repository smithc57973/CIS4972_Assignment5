/*
 * Chris Smith
 * Ana
 * Assignment 5
 * A class to define Ana Overwatch Heros.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ana : OverwatchHero
{
    // Start is called before the first frame update
    void Start()
    {
        this.heroType = "Ana";
        this.role = "Support";
        this.weapon = "Biotic Rifle";
        this.ultimate = "Nano Boost";
    }
}
