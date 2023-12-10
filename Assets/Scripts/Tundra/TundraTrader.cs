using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TundraTrader : IFriendly{
    string text = "a friendly trader";
    public string GetDetails(){
        return text;
    }
}
