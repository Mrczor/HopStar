using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrongPlatformJump : MonoBehaviour
{
    public LevelGenerator _levelGenerator;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) // Strong jump
        {
            if (collision.relativeVelocity.y <= 0f)
            {
                collision.gameObject.GetComponent<Player>().strongJump();
                Destroy(this.gameObject, 2);
            }
        }
    }
}
