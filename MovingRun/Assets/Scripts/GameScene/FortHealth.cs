using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//здоровье форта. ≈сли на нуле - выводитьс€ проигрыш
public class FortHealth : MonoBehaviour
{
    [SerializeField]
    private GameObject Star;

    public float health = 150;
    bool isShow = false;

    private void Update()
    {
        if (health <= 0 && !isShow)
        {
            Star.SetActive(true);
            Stars stars = new Stars();
            stars.StarsAnimation(Star);

            isShow = true;
        }
    }

}
