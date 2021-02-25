/*
 * Chris Smith
 * OverwatchSpawner
 * Assignment 5
 * A script to manage OverwatchHero spawn requests.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverwatchSpawner : MonoBehaviour
{
    //vars
    public OverwatchFactory factory;
    public OverwatchHero hero;
    public OverwatchHero h;
    public OverwatchHero target;
    public GameManager gm;

    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }

    //For player choice, requests spawn and sets up spawning prefab
    public void SpawnHero(string type)
    {
        hero = factory.CreateHero(type);
        Vector3 spawnPos = new Vector3(0, 0, 0);
        h = Instantiate(hero, spawnPos, Quaternion.identity);
        gm.choice.text = hero.ToString();
    }

    //For game target, requests spawn
    public void ChooseHero(string type)
    {
        target = factory.CreateHero(type);
    }
}
