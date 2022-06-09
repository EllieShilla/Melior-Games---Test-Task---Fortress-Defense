using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField]
    public GameObject bomb;
    float timeSpawn;
    float startTimeSpawn = 2f;

    float speed = 0.01f;


    private void Start()
    {
        timeSpawn = startTimeSpawn;
    }
    void Update()
    {
        if (!gameObject.GetComponent<Animator>().GetBool("isDie"))
            gameObject.transform.position = new Vector2(gameObject.transform.position.x + speed, gameObject.transform.position.y);
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag.Equals("Fort"))
        {
            gameObject.GetComponent<Animator>().SetBool("Fight", true);
            if (timeSpawn <= 0)
            {
                BombCreate bombCreate = new BombCreate();
                bombCreate.CreateBomb(bomb, gameObject.transform.position.x + 0.5f, gameObject.transform.position.y);
                timeSpawn = startTimeSpawn;
            }
            else
            {
                timeSpawn -= Time.deltaTime;
            }
        }
    }



}
