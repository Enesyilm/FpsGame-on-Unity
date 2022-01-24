using System.Collections;
using UnityEngine;

namespace EnesTalhaYılmaz_Fps.Gun{

public class Gun : MonoBehaviour
{
    enum fireModes {SemiAuto,Auto}
    [SerializeField] fireModes fireMode;
    bool fireKeyInput;
    
    EnesTalhaYılmaz_Fps.Controllers.PcControllers input;
    FireOffset fireOffset;
    MagStatus magStatus;
    FireAccuracy fireAccuracy;
    Reload reload;
    PlayEffects playEffects;
    AmmoIndicator ammoIndicator;
    DidItHitsToTarget didItHitsToTarget;
    Shoot shoot;
    
    bool isShootableOutput = false;
    
    // Start is called before the first frame update
    // Update is called once per frame
    
    void Awake(){
        fireOffset = GetComponent<FireOffset>();
        magStatus = GetComponent<MagStatus>();
        fireAccuracy = GetComponent<FireAccuracy>();
        reload = GetComponent<Reload>();
        playEffects = GetComponent<PlayEffects>();
        ammoIndicator = GetComponent<AmmoIndicator>();
        didItHitsToTarget = GetComponent<DidItHitsToTarget>();
        shoot = GetComponent<Shoot>();
        input= new EnesTalhaYılmaz_Fps.Controllers.PcControllers();
    }
    void Update()
    {
        ammoIndicator.UpdateAmmoText();
        switch(fireMode){
            case fireModes.SemiAuto:
                fireKeyInput=input.semiFireInput;
                break;
            case fireModes.Auto:
                fireKeyInput=input.autoFireInput;

                break;

        }
        isShootableOutput=fireOffset.IsShootable();
        if(fireKeyInput && isShootableOutput){
           bool IsMagEmpty=magStatus.MagazineStatus();
           fireOffset.FireTimer=0;
           if(!IsMagEmpty){
                shoot.ShootBullet();
           }
        }
        if(input.reloadInput && !reload.IsReloading){
            Debug.Log("Reloading...");
            StartCoroutine(reload.Reloadweapon(magStatus));
            

        }

    }
}

}
