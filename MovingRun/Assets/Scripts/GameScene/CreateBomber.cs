using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//создание бомб, которыми противники атакуют форт
public class CreateBomber : MonoBehaviour
{
    [SerializeField] GameObject bomber;
    int bomberCount;
    float timeSpawn;
    float startTimeSpawn = 4f;

    private void Start()
    {
        bomberCount = gameObject.GetComponent<DestroyBomberCount>().BomberCount;    
    }

    void Update()
    {
        if (bomberCount > 0)
        {
            if (timeSpawn <= 0)
            {
                GameObject bombObj = Instantiate(bomber, new Vector2(-12.02f, -2.01f), Quaternion.identity);
                bomberCount -= 1;
                timeSpawn = startTimeSpawn;
            }
            else
            {
                timeSpawn -= Time.deltaTime;
            }
        }
        
    }


}
