using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface INPCFactory{
    IEnemy CreateEnemy();
    IFriendly CreateFriendly();
    IAnimals CreateAnimals(int animalType);
}
