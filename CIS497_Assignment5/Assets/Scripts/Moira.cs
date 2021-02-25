/*
 * Chris Smith
 * Ana
 * Assignment 5
 * A class to define Moira Overwatch Heros.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moira : OverwatchHero
{
    // Start is called before the first frame update
    void Start()
    {
        this.heroType = "Moira";
        this.role = "Support";
        this.weapon = "Biotic Grasp";
        this.ultimate = "Coalescence";
    }
}
