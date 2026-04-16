using UnityEngine;

public class Movement : MonoBehaviour
{
    public float m_speed = 10.0f;
    Rigidbody2D m_Rigidbody;
    public float m_jumpPower = 175f;
    public bool m_landed = true, m_jumped = false;
    private bool m_buffer = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float xMove = Input.GetAxisRaw("Horizontal");
        float yMove = Input.GetAxisRaw("Vertical");


        //m_Rigidbody.linearVelocity = new Vector2(xMove * m_speed, m_Rigidbody.linearVelocity.y);
        m_Rigidbody.linearVelocity = new Vector2(xMove * m_speed, m_Rigidbody.linearVelocity.y);

        if ((Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.W)) && m_landed && !m_jumped)
        {
            m_Rigidbody.AddForce(Vector2.up * m_jumpPower, ForceMode2D.Impulse);
            m_buffer = false;
            m_jumped = true;
        }
        else if (!Input.GetKey(KeyCode.Space) && !Input.GetKey(KeyCode.W))
        {
            m_jumped = false;
        }

        if (m_buffer == true && m_landed == false)
        {
            m_landed = true;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        m_buffer = true;

    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        m_landed = false;
        m_buffer = false;
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        //Debug.Log("Trigger");


        if (collision.gameObject.CompareTag("Lader"))
        {
            m_jumpPower = 15f;
            m_landed = true;
            m_jumped = false;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Lader"))
        {
            m_jumpPower = 175f;
        }
    }
}
