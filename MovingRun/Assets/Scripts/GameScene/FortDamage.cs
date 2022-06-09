using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//форт получает урон
public class FortDamage : MonoBehaviour
{
    [SerializeField]
    private GameObject FortObject;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("Bomb"))
        {
            FortHealth fort= gameObject.GetComponent<FortHealth>();
            Animator animator = FortObject.GetComponent<Animator>();
            fort.health -= 25;

            collision.GetComponent<Animator>().SetBool("Boom",true);
            animator.SetFloat("HP", fort.health);
            StartCoroutine(DestroyObject(collision.gameObject));

        }
    }


    IEnumerator DestroyObject(GameObject obj)
    {
        yield return new WaitForSeconds(1f);
        Destroy(obj);
    }
}
