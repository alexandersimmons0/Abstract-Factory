using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Client : MonoBehaviour{
    private int biomeType = 0;
    private int npcType = 0;
    private int animalType = 0;
    public Text resultText;
    INPCFactory oceanFactory = new OceanFactory();
    INPCFactory desertFactory = new DesertFactory();
    INPCFactory tundraFactory = new TundraFactory();

    public void OnBiomeDropDownChange(Dropdown drop){
        biomeType = drop.value;
    }

    public void OnNPCDropDownChange(Dropdown drop){
        npcType = drop.value;
    }

    public void OnAnimalDropDownChange(Dropdown drop){
        animalType = drop.value;
    }

    public void OnCreateButton(){
        if(biomeType == 0){
            if(npcType == 0){
                IAnimals tundraAnimal = tundraFactory.CreateAnimals(animalType);
                resultText.text = tundraAnimal.GetDetails();
            }else if(npcType == 1){
                IEnemy tundraRaider = tundraFactory.CreateEnemy();
                resultText.text = tundraRaider.GetDetails();
            }else if(npcType == 2){
                IFriendly tundraTrader = tundraFactory.CreateFriendly();
                resultText.text = tundraTrader.GetDetails();
            }
        }else if(biomeType == 1){
            if(npcType == 0){
                IAnimals oceanAnimal = oceanFactory.CreateAnimals(animalType);
                resultText.text = oceanAnimal.GetDetails();
            }else if(npcType == 1){
                IEnemy pirate = oceanFactory.CreateEnemy();
                resultText.text = pirate.GetDetails();
            }else if(npcType == 2){
                IFriendly sailor = oceanFactory.CreateFriendly();
                resultText.text = sailor.GetDetails();
            }
        }else if(biomeType == 2){
            if(npcType == 0){
                IAnimals desertAnimal = desertFactory.CreateAnimals(animalType);
                resultText.text = desertAnimal.GetDetails();
            }else if(npcType == 1){
                IEnemy desertRaider = desertFactory.CreateEnemy();
                resultText.text = desertRaider.GetDetails();
            }else if(npcType == 2){
                IFriendly desertMerchant = desertFactory.CreateFriendly();
                resultText.text = desertMerchant.GetDetails();
            }
        }
    }
}
