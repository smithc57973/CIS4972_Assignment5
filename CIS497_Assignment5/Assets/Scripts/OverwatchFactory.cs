/*
 * Chris Smith
 * OverwatchFactory
 * Assignment 5
 * A script to produce OverwatchHeros.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverwatchFactory : MonoBehaviour
{
    //vars
    public OverwatchHero rein;
    public OverwatchHero zar;
    public OverwatchHero wid;
    public OverwatchHero echo;
    public OverwatchHero ana;
    public OverwatchHero moi;

    public OverwatchHero heroToSpawn;

    //Filters spawn requests
    public OverwatchHero CreateHero(string type)
    {
        heroToSpawn = null;

        if (type.Equals("Reinhardt"))
        {
            heroToSpawn = rein;
        }
        else if (type.Equals("Zarya"))
        {
            heroToSpawn = zar;
        }
        else if(type.Equals("Echo"))
        {
            heroToSpawn = echo;
        }
        else if (type.Equals("Widowmaker"))
        {
            heroToSpawn = wid;
        }
        else if (type.Equals("Ana"))
        {
            heroToSpawn = ana;
        }
        else if (type.Equals("Moira"))
        {
            heroToSpawn = moi;
        }

        return heroToSpawn;
        
    }
}
