using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesertMerchant : IFriendly{
    string text = "a friendly merchant";
    public string GetDetails(){
        return text;
    }
}
