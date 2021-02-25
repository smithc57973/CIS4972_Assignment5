/*
 * Chris Smith
 * GameManager
 * Assignment 5
 * A script to manage game state.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum GameState { Start, Target, Player, Compare};

public class GameManager : MonoBehaviour
{
    //vars
    public PlayerController pc;
    public OverwatchSpawner os;
    public GameState state;
    public int hintsGiven;
    public int pointsToAward;
    public Text hint;
    public Text choice;
    public Text points;
    public Text tutorial;

    // Start is called before the first frame update
    void Start()
    {
        //Setup
        state = GameState.Start;
        pc = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
        os = GameObject.FindGameObjectWithTag("Spawner").GetComponent<OverwatchSpawner>();
        hintsGiven = 0;
        pointsToAward = 4;
        hint.enabled = false;
        choice.enabled = false;
        points.enabled = false;
        StartCoroutine(Tutorial());
    }

    // Update is called once per frame
    void Update()
    {
        points.text = "Points: " + pc.points.ToString();
    }

    //The game chooses a target hero and displays a hint, then transfers to player state
    public void Choose()
    {
        if (state == GameState.Target)
        {
            hintsGiven = 0;
            pointsToAward = 4;
            int r = Random.Range(0, 6);
            switch (r)
            {
                case 0:
                    os.ChooseHero("Reinhardt");
                    hint.text = "Hint: " + os.target.GiveHint(hintsGiven);
                    break;
                case 1:
                    os.ChooseHero("Zarya");
                    hint.text = "Hint: " + os.target.GiveHint(hintsGiven);
                    break;
                case 2:
                    os.ChooseHero("Echo");
                    hint.text = "Hint: " + os.target.GiveHint(hintsGiven);
                    break;
                case 3:
                    os.ChooseHero("Widowmaker");
                    hint.text = "Hint: " + os.target.GiveHint(hintsGiven);
                    break;
                case 4:
                    os.ChooseHero("Ana");
                    hint.text = "Hint: " + os.target.GiveHint(hintsGiven);
                    break;
                case 5:
                    os.ChooseHero("Moira");
                    hint.text = "Hint: " + os.target.GiveHint(hintsGiven);
                    break;
                default:
                    break;
            }
            IncrementHints();
            state = GameState.Player;
        }
    }

    //Once the player has chosen their hero, the hero is compared to the target hero and points are awarded
    public void Compare()
    {
        if (state == GameState.Compare)
        {
            if (os.hero == os.target)
            {
                pointsToAward -= hintsGiven;
                pc.points += pointsToAward;
                hint.text = "You guessed correctly, awarding " + pointsToAward + " points. Next Hero.";
                StartCoroutine(Delay());
            }
            else
            {
                hint.text = "You guessed incorrectly. The correct guess was " + os.target.heroType + ". Next Hero.";
                StartCoroutine(Delay());
            }
        }
    }

    //A small delay between Compare and Target states
    public IEnumerator Delay()
    {
        yield return new WaitForSeconds(6f);
        Destroy(os.h.gameObject);
        hint.text = "Hint: ";
        choice.text = "";
        state = GameState.Target;
        Choose();
    }

    //Plays the tutorial messages and transfers to Target state
    public IEnumerator Tutorial()
    {
        tutorial.text = "Tutorial:\nYou will be given a hint about an Overwatch hero.";
        yield return new WaitForSeconds(3f);
        tutorial.text = "Tutorial:\nTo get more hints, press H. More hints = Less Points.";
        yield return new WaitForSeconds(3f);
        tutorial.text = "Tutorial:\nWhen you're ready, click a button to choose a hero.";
        yield return new WaitForSeconds(3f);
        tutorial.text = "Tutorial:\nIf you are correct, you will receive points based on the number of hints used.";
        yield return new WaitForSeconds(3f);
        tutorial.text = "Tutorial:\nIf you are incorrect, you will receive no points.";
        yield return new WaitForSeconds(3f);
        tutorial.text = "Tutorial:\nPress R at any time to reset the game.";
        yield return new WaitForSeconds(3f);
        tutorial.enabled = false;
        hint.enabled = true;
        choice.enabled = true;
        points.enabled = true;
        state = GameState.Target;
        Choose();
    }

    //Increments hintsGiven if appropriate
    public void IncrementHints()
    {
        if (hintsGiven < 4)
        {
            hintsGiven++;
        }
    }    
}
