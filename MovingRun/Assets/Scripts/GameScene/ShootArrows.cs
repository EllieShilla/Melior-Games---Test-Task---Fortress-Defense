using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//атаки игрока. По нажатию клавишы, создаються стрелы
public class ShootArrows : MonoBehaviour
{
   public void Shoot()
    {
        foreach(GameObject archer in GameObject.FindGameObjectsWithTag("Archer"))
        {
            archer.GetComponent<Animator>().SetBool("Fight", true);
            StartCoroutine(StopShooting(archer));
        }
    }

    IEnumerator StopShooting(GameObject archer)
    {
        yield return new WaitForSeconds(0.5f);
        archer.GetComponent<CreateRow>().CreateArrow();
        archer.GetComponent<Animator>().SetBool("Fight", false);
    }
}
