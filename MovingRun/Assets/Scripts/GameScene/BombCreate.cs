using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombCreate : MonoBehaviour
{
    public void CreateBomb(GameObject bomb, float posX, float posY)
    {
        GameObject bombObj= Instantiate(bomb, new Vector2(posX, posY), Quaternion.identity);
        bombObj.tag = "Bomb";
    }
}
