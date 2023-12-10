using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TundraFactory : INPCFactory{
    public IEnemy CreateEnemy(){
        return new TundraRaider();
    }

    public IFriendly CreateFriendly(){
        return new TundraTrader();
    }

    public IAnimals CreateAnimals(int animalType){
        if(animalType == 0){
            return new Caribou();
        }else if(animalType == 1){
            return new PolarBear();
        }else{
            return null;
        }
    }
}
