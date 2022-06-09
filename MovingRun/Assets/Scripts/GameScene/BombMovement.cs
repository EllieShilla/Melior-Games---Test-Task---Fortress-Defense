using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombMovement : MonoBehaviour
{
    private void Update()
    {
        BombMove();
    }
    void BombMove()
    {
        gameObject.transform.position = new Vector2(gameObject.transform.position.x + 0.06f, gameObject.transform.position.y);
    }
}
