using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sailor : IFriendly{
    string text = "a friendly sailor";
    public string GetDetails(){
        return text;
    }
}
