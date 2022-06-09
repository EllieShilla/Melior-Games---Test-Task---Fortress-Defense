using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//вывод плашки со звуздами
public class Stars : MonoBehaviour
{
    public void StarsAnimation(GameObject resultObj)
    {
        Animator animator= resultObj.GetComponent<Animator>();
        animator.SetFloat("Stars", 0);

        float health = GameObject.Find("FortHealth").GetComponent<FortHealth>().health;
        if (health > 86 && health<151)
        {
            animator.SetFloat("Stars", 3);
        }
        else if (health > 66 && health<85)
            animator.SetFloat("Stars", 2);
        else if (health > 46 && health < 65)
            animator.SetFloat("Stars", 1);
        else
            animator.SetFloat("Stars", 0);

    }

}
