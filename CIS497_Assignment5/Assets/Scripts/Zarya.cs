﻿/*
 * Chris Smith
 * Ana
 * Assignment 5
 * A class to define Zarya Overwatch Heros.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zarya : OverwatchHero
{
    // Start is called before the first frame update
    void Start()
    {
        this.heroType = "Zarya";
        this.role = "Tank";
        this.weapon = "Particle Cannon";
        this.ultimate = "Graviton Surge";
    }
}
