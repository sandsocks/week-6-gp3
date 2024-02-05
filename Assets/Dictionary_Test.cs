using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dictionary_Test : MonoBehaviour
{
    Dictionary<string, int> BountyPirates = new Dictionary<string, int>()
    {
        {"Luffy", 300000000},
        {"Chopper", 1000 }
    };

    Dictionary<string, string> CelestialDragon = new Dictionary<string, string>()
    {
        {"Saturn", "Egghead" }
    };
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            UpdateBounty("Luffy", 6000000);
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            AddPirate("Kuma", 34000);
            Debug.Log("BountyPirates Count: " + BountyPirates.Count);
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (CelestialDragon.ContainsKey("Saturn") && CelestialDragon.ContainsValue("Egghead"))
            {
                DeletePirate("Kuma");
            }
        }
    }

    void UpdateBounty(string namePirate, int newBounty)
    {
        BountyPirates[namePirate] = newBounty;
    }

    void AddPirate(string namePirate, int bounty)
    {
        BountyPirates.Add(namePirate, bounty);
    }

    void DeletePirate(string namePirate)
    {
        BountyPirates.Remove(namePirate);
    }
}
