using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.Timeline.TimelinePlaybackControls;

public class Movement : MonoBehaviour
{
    public float horizontal;
    public float speed;
    public float jump;
    private float Move;
    public Text winText;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Move = Input.GetAxisRaw("Horizontal");

        rb.velocity = new Vector2(speed = Move, rb.velocity.y);

        if (Input.GetButtonDown("Jump"))
        {
            rb.AddForce(new Vector2(rb.velocity.x, jump));
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "win")
        {
            winText.gameObject.SetActive(true);
        }

    }
}
