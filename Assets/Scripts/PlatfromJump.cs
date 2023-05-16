using UnityEngine;

public class PlatfromJump : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) // Jump
        {
            if (collision.relativeVelocity.y <= 0f)
            {
                collision.gameObject.GetComponent<Player>().defaultJump();
                Destroy(this.gameObject, 3);
            }
        }
    }
}
