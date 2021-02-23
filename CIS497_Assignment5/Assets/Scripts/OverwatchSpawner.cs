using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverwatchSpawner : MonoBehaviour
{
    public OverwatchFactory factory;
    //public GameObject hero;
    public OverwatchHero hero;
    UIManager ui;

    // Start is called before the first frame update
    void Start()
    {
        ui = GameObject.FindGameObjectWithTag("UIManager").GetComponent<UIManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnHero(string type)
    {
        hero = factory.CreateHero(type);
        Vector3 spawnPos = new Vector3(0, 0, 0);
        Instantiate(hero, spawnPos, Quaternion.identity);
        ui.hint.text = hero.ToString();
    }
}
