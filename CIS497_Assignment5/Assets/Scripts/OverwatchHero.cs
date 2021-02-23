using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverwatchHero : MonoBehaviour
{
    public string heroType;
    public string role;
    public string weapon;
    public string ultimate;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override string ToString()
    {
        return "Hero " + this.heroType + " with role " + this.role + " uses weapon " + this.weapon + " and ultimate " + this.ultimate + "\n";
    }
}
