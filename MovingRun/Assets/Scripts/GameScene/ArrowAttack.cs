using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowAttack : MonoBehaviour
{
    private void Update()
    {
        ArrowMove();
    }
    void ArrowMove()
    {
        gameObject.transform.position = new Vector2(gameObject.transform.position.x - 0.06f, gameObject.transform.position.y);
    }
}
