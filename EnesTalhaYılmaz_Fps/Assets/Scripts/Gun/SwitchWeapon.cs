using UnityEngine;

public class SwitchWeapon : MonoBehaviour
{
    int selectedWeapon=0;
    EnesTalhaYılmaz_Fps.Controllers.PcControllers input;
    int maxWeaponSize;
    // Update is called once per frame
    void Awake(){
        input =new EnesTalhaYılmaz_Fps.Controllers.PcControllers();
        maxWeaponSize=gameObject.transform.childCount;
    }
    void Update()
    {
        if(input.switchWeaponInput){
        selectedWeapon=SwitchWeaponIndex(selectedWeapon);
        SelectWeapon(selectedWeapon);
        }
        
    }
    int SwitchWeaponIndex(int selectedWeaponParam){    
            selectedWeaponParam++;
            if(selectedWeaponParam>maxWeaponSize-1){
                selectedWeaponParam=0;
            }  
        return selectedWeaponParam;

    }
    void SelectWeapon(int selectedWeaponParam){
        int type=0;
        foreach(Transform weapon in transform){
            if(type==selectedWeaponParam){
                weapon.gameObject.SetActive(true);
                Debug.Log("weapon switched to :"+ weapon.gameObject.name);
                
            }
            else{
                weapon.gameObject.SetActive(false);
            }
            type++;

        }
    }
}
