using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EnesTalhaYılmaz_Fps.Gun{
public class DidItHitsToTarget : MonoBehaviour
{
    [SerializeField] float damage=40f;
    FireAccuracy fireAccuracy;
    void Awake(){
        fireAccuracy=GetComponent<FireAccuracy>();
    }
    public void GiveDamageToTarget(RaycastHit hit){
        Target target = hit.transform.GetComponent<Target>();
         if(target!=null && fireAccuracy.HitChance()==true ){
                target.TakeDamage(damage);
                Debug.Log("Success");
            }
            else{
                Debug.Log("Fail");
            }
    }
    
}
}

