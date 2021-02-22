using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
     void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Enemy")
        {
            FindObjectOfType<GameManager>().EndGame();
        }

        if (collisionInfo.collider.tag == "bird")
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
