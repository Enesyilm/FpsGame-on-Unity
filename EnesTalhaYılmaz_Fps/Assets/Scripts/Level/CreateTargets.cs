using UnityEngine;
using UnityEngine.UI;

namespace EnesTalhaYılmaz_Fps.Level{
public class CreateTargets : MonoBehaviour
{
    [Range(1,5)][SerializeField] int numberOfTargets=1;
    public Transform targetHolder;
    [SerializeField] Transform pirateModels;
    Transform spawnPoints;
    [SerializeField] Text targetText;
    LevelCreator levelCreator;

    void Awake(){
        spawnPoints=GameObject.FindWithTag("EnemySpawnPoints").transform;
        levelCreator=GetComponent<LevelCreator>();
    }
    public void SpawnTargets(){

        if(targetHolder.childCount == 0 && levelCreator.NumberOfLevels>levelCreator.LevelCounter)
        {
            for(int index=0;index<numberOfTargets;index++){
            
            Instantiate(pirateModels.GetChild(Random.Range(0,pirateModels.childCount)),spawnPoints.GetChild(index).position,Quaternion.LookRotation(Vector3.back),targetHolder);
            }
            
            if(levelCreator.LevelCounter>0){
                StartCoroutine(levelCreator.ShowLevelStatusText());

            }
            levelCreator.LevelCounter++;
        }

        else if(targetHolder.childCount == 0 && levelCreator.NumberOfLevels==levelCreator.LevelCounter){
             StartCoroutine(levelCreator.ShowLevelStatusText());
        }
    }
    public void UpdateTargetText(){
        targetText.text= targetHolder.childCount.ToString();

    }
}
}

