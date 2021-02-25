/*
 * Chris Smith
 * OverwatchHero
 * Assignment 5
 * A class to define Overwatch Heros.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverwatchHero : MonoBehaviour
{
    //vars
    public string heroType;
    public string role;
    public string weapon;
    public string ultimate;

    //Displays hero info
    public override string ToString()
    {
        return "Hero " + this.heroType + " with role " + this.role + " uses weapon " + this.weapon + " and ultimate " + this.ultimate + ".\n";
    }

    //Based on number of hints already given, displays a hint about hero characteristics
    public string GiveHint(int h)
    {
        switch (h)
        {
            case 0:
                return this.role;
            case 1:
                return this.weapon;
            case 2:
                return this.ultimate;
            case 3:
                return this.heroType;
            default:
                return this.role;
        }
    }
}
