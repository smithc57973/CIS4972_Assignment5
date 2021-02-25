/*
 * Chris Smith
 * Ana
 * Assignment 5
 * A class to define Widowmaker Overwatch Heros.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Widowmaker : OverwatchHero
{
    // Start is called before the first frame update
    void Start()
    {
        this.heroType = "Widowmaker";
        this.role = "DPS";
        this.weapon = "Widow's Kiss";
        this.ultimate = "Infrasight";
    }
}
