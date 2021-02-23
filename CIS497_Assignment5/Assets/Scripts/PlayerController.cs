using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    OverwatchSpawner os;

    // Start is called before the first frame update
    void Start()
    {
        os = GameObject.FindGameObjectWithTag("Spawner").GetComponent<OverwatchSpawner>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            os.SpawnHero("Reinhardt");
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            os.SpawnHero("Zarya");
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            os.SpawnHero("Echo");
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            os.SpawnHero("Widowmaker");
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            os.SpawnHero("Ana");
        }
        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            os.SpawnHero("Moira");
        }
    }
}
