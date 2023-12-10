using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TundraRaider : IEnemy{
    string text = "a tundra raider is attacking";
    public string GetDetails(){
        return text;
    }
}
