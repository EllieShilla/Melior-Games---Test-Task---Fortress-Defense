using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//получение урона противником
public class EnemyDamage : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("Arrow"))
        {
            Destroy(collision.gameObject);

            gameObject.GetComponent<Enemy>().healt -= 25;

            if (gameObject.GetComponent<Enemy>().healt < 0)
            {
                gameObject.GetComponent<Animator>().SetBool("isDie", true);
                StartCoroutine(DestroyObject(gameObject));
                gameObject.GetComponent<Collider2D>().Equals(false);
            }
        }
        else if (collision.tag.Equals("Line")) 
        {
            DestroyBomberCount.DestroyBomber += 1;
        }

    }

    IEnumerator DestroyObject(GameObject enemy)
    {
        yield return new WaitForSeconds(1.7f);
        DestroyBomberCount.DestroyBomber += 1;
        Destroy(enemy);
    }
}
