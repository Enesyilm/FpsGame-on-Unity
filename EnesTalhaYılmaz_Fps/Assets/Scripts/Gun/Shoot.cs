using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EnesTalhaYılmaz_Fps.Gun{
public class Shoot : MonoBehaviour
{
    PlayEffects playEffects;
    DidItHitsToTarget didItHitsToTarget;
    [SerializeField] Camera FpsCamera;
    float range=1000f;
    void Awake(){
        playEffects=GetComponent<PlayEffects>();
        didItHitsToTarget=GetComponent<DidItHitsToTarget>();
    }
   public void ShootBullet(){
        Debug.Log("Fire");
        playEffects.PlayMuzzleFlashEffect();
        RaycastHit hit;
        if(Physics.Raycast(FpsCamera.transform.position,FpsCamera.transform.forward,out hit,range)){           
           didItHitsToTarget.GiveDamageToTarget(hit);
            playEffects.PlayImpactEffect(hit);
        }
    }
}
}

