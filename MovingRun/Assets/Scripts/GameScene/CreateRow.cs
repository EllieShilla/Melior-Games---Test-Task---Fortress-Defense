using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateRow : MonoBehaviour
{
    [SerializeField]
    public GameObject arrow;

   public void CreateArrow()
    {
        MyArrow arrowPos = gameObject.GetComponent<MyArrow>();
        Instantiate(arrow, new Vector2(arrowPos.arrowPositionX, arrowPos.arrowPositionY), Quaternion.identity);
    }
}
