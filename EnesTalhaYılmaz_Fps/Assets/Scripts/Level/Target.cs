using TMPro;
using UnityEngine;

public class Target : MonoBehaviour
{
    [SerializeField] private float maxHealth=100f;
     private TextMeshPro HealthText;
    EnesTalhaYılmaz_Fps.Controllers.PcControllers input;
    float currentHealth=100f;
    void Awake(){
        input=new EnesTalhaYılmaz_Fps.Controllers.PcControllers();
    }
    void Start(){
        currentHealth=maxHealth;
        HealthText=GetComponentInChildren<TextMeshPro>();
    }
    void Update(){
        UpdateHealthText();

        if(input.renewTargetHealthsInput){
            currentHealth=maxHealth;
        }
    }
    void UpdateHealthText(){
        HealthText.text=currentHealth.ToString();
        
    }

    public void TakeDamage (float amount){
        currentHealth-=amount;
        if(currentHealth<=0f){
            Die();
        }
    }
    void Die(){
        Debug.Log("Target Destroyed");
        Destroy(gameObject);
    }
}
