using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//подсчет кол-ва созданных и убитых противников
public class DestroyBomberCount : MonoBehaviour
{
    public  int BomberCount;
    public static int DestroyBomber=0;
    bool isShow = false;
    [SerializeField]
    private GameObject Star;

    private void Start()
    {
        DestroyBomber = 0;
    }
    private void Update()
    {
        if (DestroyBomber == BomberCount && !isShow)
        {
            Star.SetActive(true);

            Stars stars = new Stars();
            stars.StarsAnimation(Star);

            isShow = true;
        }
    }
}
