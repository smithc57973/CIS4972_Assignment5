using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverwatchFactory : MonoBehaviour
{
    /*public GameObject rein;
    public GameObject zar;
    public GameObject wid;
    public GameObject echo;
    public GameObject ana;
    public GameObject moi;

    public GameObject heroToSpawn;*/
    public OverwatchHero rein;
    public OverwatchHero zar;
    public OverwatchHero wid;
    public OverwatchHero echo;
    public OverwatchHero ana;
    public OverwatchHero moi;

    public OverwatchHero heroToSpawn;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public OverwatchHero CreateHero(string type)
    {
        heroToSpawn = null;

        if (type.Equals("Reinhardt"))
        {
            heroToSpawn = rein;
            if (heroToSpawn.GetComponent<Reinhardt>() == null)
            {
                //heroToSpawn.AddComponent<Reinhardt>();
            }
        }
        else if (type.Equals("Zarya"))
        {
            heroToSpawn = zar;
            if (heroToSpawn.GetComponent<Zarya>() == null)
            {
                //heroToSpawn.AddComponent<Zarya>();
            }
        }
        else if(type.Equals("Echo"))
        {
            heroToSpawn = echo;
            if (heroToSpawn.GetComponent<Echo>() == null)
            {
                //heroToSpawn.AddComponent<Echo>();
            }
        }
        else if (type.Equals("Widowmaker"))
        {
            heroToSpawn = wid;
            if (heroToSpawn.GetComponent<Widowmaker>() == null)
            {
                //heroToSpawn.AddComponent<Widowmaker>();
            }
        }
        else if (type.Equals("Ana"))
        {
            heroToSpawn = ana;
            if (heroToSpawn.GetComponent<Ana>() == null)
            {
                //heroToSpawn.AddComponent<Ana>();
            }
        }
        else if (type.Equals("Moira"))
        {
            heroToSpawn = moi;
            if (heroToSpawn.GetComponent<Moira>() == null)
            {
                //heroToSpawn.AddComponent<Moira>();
            }
        }

        Debug.Log("Sending " + heroToSpawn);
        return heroToSpawn;
        
    }
}
