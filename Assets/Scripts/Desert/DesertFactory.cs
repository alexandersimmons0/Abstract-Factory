using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesertFactory : INPCFactory{
    public IEnemy CreateEnemy(){
        return new DesertRaider();
    }

    public IFriendly CreateFriendly(){
        return new DesertMerchant();
    }

    public IAnimals CreateAnimals(int animalType){  
        if(animalType == 0){
            return new Addax();
        }else if(animalType == 1){
            return new SandCat();
        }else{
            return null;
        }
    }
}
