using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Rigidbody2D rb;
    public float startSpeed;
    public Vector2[] startDirection;
    public AudioSource ballSound;

    // Start is called before the first frame update
    void Start()
    {
        int selectStartDirection = Random.Range(0,3);
       rb.velocity = startDirection[selectStartDirection] * startSpeed;
    }

    // Update is called once per frame
    public void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (!collision.gameObject.CompareTag("LeftBorder") && !collision.gameObject.CompareTag("RightBorder"))
        {
            ballSound.Play();
        }

        {
            
        }

        if (collision.gameObject.CompareTag("LeftBorder"))

        {
            GameObject.FindAnyObjectByType<GameController>().AddScore(false);
            Debug.Log("Ponto para o jogador 2");
        }

        if (collision.gameObject.CompareTag("RightBorder"))
        {
            GameObject.FindAnyObjectByType<GameController>().AddScore(true);
            Debug.Log("Ponto para o jogador 1");

        }
    }
   
}
