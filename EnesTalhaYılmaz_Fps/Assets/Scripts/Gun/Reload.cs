using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EnesTalhaYılmaz_Fps.Gun{
public class Reload : MonoBehaviour
{
    [SerializeField] float reloadTime=10f;
    private bool isReloading = false;
    public bool IsReloading{
        get{return isReloading;}
        set{isReloading=value;}
    }

    void OnEnable(){
        isReloading=false;
    }
   public IEnumerator Reloadweapon(EnesTalhaYılmaz_Fps.Gun.MagStatus magStatus){
            isReloading=true;
            yield return new WaitForSeconds(reloadTime);
            magStatus.CurrentAmmo=magStatus.MagazineCap;
            Debug.Log("Reloaded");
            isReloading=false;
    }
}
}

