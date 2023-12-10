using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OceanFactory : INPCFactory{
    public IEnemy CreateEnemy(){
        return new Pirate();
    }

    public IFriendly CreateFriendly(){
        return new Sailor();
    }

    public IAnimals CreateAnimals(int animalType){
        if(animalType == 0){
            return new Dugong();
        }else if(animalType == 1){
            return new Shark();
        }else{
            return null;
        }
        
    }
}
