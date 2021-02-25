/*
 * Chris Smith
 * PlayerController
 * Assignment 5
 * A script to handle player input.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    //vars
    public OverwatchSpawner os;
    public GameManager gm;
    public int points;

    // Start is called before the first frame update
    void Start()
    {
        //Setup
        os = GameObject.FindGameObjectWithTag("Spawner").GetComponent<OverwatchSpawner>();
        gm = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
        points = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //While in player state, pressing h gives hints
        if (gm.state == GameState.Player)
        {
            if (Input.GetKeyDown(KeyCode.H))
            {
                if (gm.hintsGiven < 4)
                {
                    gm.hint.text += ", " + os.target.GiveHint(gm.hintsGiven);
                    gm.IncrementHints();
                }
            }
        }

        //Reset game
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    //Based on button input, selects player guess and spawns prefab, then transfers to Compare state
    public void MakeGuess(string g)
    {
        if (gm.state == GameState.Player)
        {
            switch (g)
            {
                case "r":
                    os.SpawnHero("Reinhardt");
                    break;
                case "z":
                    os.SpawnHero("Zarya");
                    break;
                case "e":
                    os.SpawnHero("Echo");
                    break;
                case "w":
                    os.SpawnHero("Widowmaker");
                    break;
                case "a":
                    os.SpawnHero("Ana");
                    break;
                case "m":
                    os.SpawnHero("Moira");
                    break;
                default:
                    break;
            }

            gm.state = GameState.Compare;
            gm.Compare();
        }
    }
}
