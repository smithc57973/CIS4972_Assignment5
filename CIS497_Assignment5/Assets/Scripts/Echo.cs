using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Echo : OverwatchHero
{
    // Start is called before the first frame update
    void Start()
    {
        this.heroType = "Echo";
        this.role = "DPS";
        this.weapon = "Tri-Shot";
        this.ultimate = "Duplicate";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
