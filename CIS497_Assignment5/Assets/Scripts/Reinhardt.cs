﻿/*
 * Chris Smith
 * Ana
 * Assignment 5
 * A class to define Reinhardt Overwatch Heros.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reinhardt : OverwatchHero
{
    // Start is called before the first frame update
    void Start()
    {
        this.heroType = "Reinhardt";
        this.role = "Tank";
        this.weapon = "Rocket Hammer";
        this.ultimate = "Earth Shatter";
    }
}
