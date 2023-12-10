using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shark : IAnimals{
    string text = "a shark";
    public string GetDetails(){
        return text;
    }
}
