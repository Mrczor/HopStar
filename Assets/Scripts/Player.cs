using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Player : MonoBehaviour
{
    [SerializeField] float speed;
    Rigidbody2D rb;
    [SerializeField] float jumpForce;
    [SerializeField] float strongJumpForce;
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        if (!PlayerPrefs.HasKey("Level"))
        {
            PlayerPrefs.SetInt("Level", 0);
        }
        
    }

    private float firstTouchx;
    void Update() // Move
    {
        float diff = 0;
        Vector3 moveVector = new Vector3(0, 0, 0);
        if (Input.GetMouseButtonDown(0))
        {
            firstTouchx = Input.mousePosition.x;
        }
        else if (Input.GetMouseButton(0))
        {
            float lastTouchX = Input.mousePosition.x;
            diff = lastTouchX - firstTouchx;
            moveVector += new Vector3(diff * Time.deltaTime * speed, 0, 0);
            firstTouchx = lastTouchX;
        }
        transform.position += moveVector;
    }
    public void defaultJump() // Default jump
    {
        rb.AddForce(Vector2.up * jumpForce);
    }
    public void strongJump() // Strong jump
    {
        rb.AddForce(Vector2.up * strongJumpForce);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Finish")) // Win
        {
            SceneManager.LoadScene("Finish");
            PlayerPrefs.SetInt("Level", PlayerPrefs.GetInt("Level") + 1);

        }
        else if (collision.gameObject.CompareTag("Dead")) // Dead
        {
            SceneManager.LoadScene("DeadUI");
        }
    }
}