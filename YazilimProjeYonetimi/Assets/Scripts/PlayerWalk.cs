using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
            SoundScript.PlaySound("walk");
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
            SceneManager.LoadScene("LoseGame");
        }
        
    }

    public void Heal(int heal)
    {
        if (currentHealth > 100)
        {
            currentHealth = 100;
            healthBar.SetHealth(currentHealth);
        }
        else
        {
            currentHealth += heal;
            healthBar.SetHealth(currentHealth);
        }
    }
}
