using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pirate : IEnemy{
    string text = "a pirate is attacking";
    public string GetDetails(){
        return text;
    }
}
