using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesertRaider : IEnemy{
    string text = "a desert raider is attacking";
    public string GetDetails(){
        return text;
    }
}
