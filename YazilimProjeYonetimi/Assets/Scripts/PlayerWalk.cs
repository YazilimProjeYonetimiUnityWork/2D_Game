using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWalk : MonoBehaviour
{
    public float speed = 5f;

    private Rigidbody2D myBody;
    private Animator anim;

    public int maxHealth = 100;
    public int currentHealth;

    public HealthBar healthBar;
    

    void Awake()
    {
        myBody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    void FixedUpdate()
    {
        PlayerMovement();
    }

    void Update()
    {
        
    }

    void PlayerMovement()
    {
        float h = Input.GetAxisRaw("Horizontal");
        if (h > 0)
        {
            myBody.velocity = new Vector2(speed, myBody.velocity.y);
        }
        else
        {
            myBody.velocity = new Vector2(0f, myBody.velocity.y);
        }
        anim.SetInteger("Speed", Mathf.Abs((int)myBody.velocity.x));
    }

    public void TakeDamage(int damage)
    {
        if(currentHealth > 0)
        {
            currentHealth -= damage;
            healthBar.SetHealth(currentHealth);
        }
        else
        {
            Time.timeScale = 0f;
        }
        
    }

    public void Heal(int heal)
    {
        currentHealth += heal;
        healthBar.SetHealth(currentHealth);
    }
}
