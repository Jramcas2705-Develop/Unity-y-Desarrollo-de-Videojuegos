using System.Collections;
using System.Collections.Generic;
using System.Xml;
using NUnit.Framework;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Arthur : MonoBehaviour
{
    //Referencias
    public Rigidbody2D Rb2d;
    private Animator Animator;
    private AudioSource Audio;
    public GameObject BulletPrefab;
    public LayerMask FloorLayer;
    public GameObject Zombie;
    public Zombie zombiescript;
    public SpriteRenderer SpriteRenderer;
    public Transform attackPoint;
    public HealthBarScript HealthBar;
    public TMP_Text AmmoCount;
    public HidingPlacesScript HiddingPS;
    public SolidHidingPlacesScript SoHidding;

    //Estadisticas basicas
    public int MaxHealth = 100;
    public int currentHealth;
    public int MaxAmmo = 10;
    public int currentAmmo;
    //Movimiento
    float moveX;
    public float speed = 0.8f;
    public float defaultspeed;
    public float sprintspeed;
    public bool sprinting;
    public float JumpForce = 1f;
    public bool IsGrounded;
    public float LengthRay = 0.2f;
    public bool LootAmmo = false;
    public bool LootHealth = false;
    //Animación
    private float Inactivity = 0f;
    public float InactivityAnimation = 5f;
    public bool IsInactive;
    public bool lookingright;
    //Disparar/atacar
    public float LastShoot;
    public bool Shooting;
    private float LastAttack;
    public bool Knife = false;
    public LayerMask ZombieLayer;
    public float attackRange = 0.1f;
    public int attackDamage = 25;
    public float offset = 0.5f;
    public float recoilForce = 2f;
    //Interacciones con Zombie
    public float distance;
    public bool Death = false;
    public bool Hidden = false;
    public bool HiddenInGrass = false;
    public bool HiddenInSoObj = false;
    //Audio
    [SerializeField] private AudioClip Disparar;

    //Zombie ZombieScript;

    // Start is called before the first frame update
    void Start()
    {
        Rb2d = GetComponent<Rigidbody2D>();
        Animator = GetComponent<Animator>();
        Audio = GetComponent<AudioSource>();
        SpriteRenderer = GetComponent<SpriteRenderer>();
        zombiescript = Zombie.GetComponent<Zombie>();
        defaultspeed = speed;
        sprintspeed = speed + 0.5f;
        Animator.speed = 0.8f;
        currentHealth = MaxHealth;
        currentAmmo = 0;
        HealthBar.SetMaxHealth(MaxHealth);
        SpriteRenderer.sortingOrder = 3;
    }

    // Update is called once per frame
    void Update()
    {
        //UI
        HealthBar.SetHealth(currentHealth);
        AmmoCount.text = "Munición: " + currentAmmo;
        //Debug.Log("Arhur tiene " + Health + " de vida y "+ Ammo +" de munición");

        //Movimiento
        moveX = Input.GetAxisRaw("Horizontal");

        //if(moveX < 0.0f) transform.localScale = new Vector3(-1.0f, 1.0f, 1.0f);
        //else transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);

        Animator.SetBool("Walkingleft", moveX < 0.0f);
        Animator.SetBool("Walkingright", moveX > 0.0f);

        if (moveX < 0.0f)
        {
            lookingright = false;

        }
        else if (moveX > 0.0f)
        {
            lookingright = true;
        }

        if (moveX != 0.0f)
        {
            Inactivity = 0f;
            IsInactive = false;
            Animator.SetBool("Inactivity", false);
            Animator.SetBool("Pistolright", false);
            Animator.SetBool("Pistolleft", false);
            Animator.SetBool("Aimleft", false);
            Animator.SetBool("Aimright", false);

            //Inactividad
        }
        else Inactivity += Time.deltaTime;

        if (Inactivity >= InactivityAnimation)
        {
            IsInactive = true;
            Animator.SetBool("Inactivity", true);
        }

        //Salto y detección de suelo mediante Raycast.

        RaycastHit2D Hit = Physics2D.Raycast(transform.position, Vector2.down, LengthRay, FloorLayer);
        Debug.DrawRay(transform.position, Vector2.down * LengthRay, Color.red);

        if (Hit.collider != null)
        {
            IsGrounded = true;
            //Debug.Log("Raycast detecting " + Hit.collider.gameObject.name);
        }
        else IsGrounded = false;

        if (Input.GetKeyDown(KeyCode.W) && IsGrounded)
        {
            Jump();
        }
        //Esprintar
        if (Input.GetKey(KeyCode.LeftShift) && !HiddenInGrass)
        {
            speed = sprintspeed;
            sprinting = true;
        }
        else
        {
            speed = defaultspeed;
            sprinting = false;
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            LootAmmo = true;
            LootHealth = true;
        }
        else
        {
            LootAmmo = false;
            LootHealth = false;
        }
        //Escondites atravesables (Hierba o arbustos)
        if (Input.GetKeyDown(KeyCode.E) && HiddingPS.PlayerInsideGrass && !zombiescript.WatchPlayer)
        {
            HiddenInGrass = !HiddenInGrass; // Hidden = true -> Hidden = !true -> Hidden = false; Hidden = false -> Hidden = !false -> Hidden = true;

            if (HiddenInGrass)
            {
                Inactivity = 0;
                IsInactive = false;
                Hidden = true;
                SpriteRenderer.color = Color.gray;
                SpriteRenderer.sortingOrder = 1;
            }
            else
            {
                Hidden = false;
                SpriteRenderer.color = Color.white;
                SpriteRenderer.sortingOrder = 3;
            }
        }

        // Opcional: si sales del trigger, forzar salir del escondite
        if (!HiddingPS.PlayerInsideGrass && HiddenInGrass)
        {
            HiddenInGrass = false;
            Hidden = false;
            SpriteRenderer.color = Color.white;
            SpriteRenderer.sortingOrder = 3;
            LootAmmo = false;
            LootHealth = false;
        }
        //Escondites no atravesables (Objetos sólidos)
        if (SoHidding.PlayerInsideSolid)
        {
            Debug.Log("Arthur is Hidden in solid object by ArhurScript"+ SoHidding.PlayerInsideSolid);
            HiddenInSoObj = true;
            Hidden = true;
            IsInactive = false;
            SpriteRenderer.color = Color.gray;
        }
        else if(!HiddenInGrass)
        {
            HiddenInSoObj = false;
            Hidden = false;
            SpriteRenderer.color = Color.white;
        }
        //Detecta el input para el disparo, la dirección del jugador y activa la animación, la animacion es la que llama al evento Shoot() en un frame dentro del panel animation.
        if (Input.GetKey(KeyCode.Space) && moveX == 0.0f && Time.time > LastShoot + 0.5f && !Hidden)
        {
            Shooting = true;
            if (!lookingright)
            {
                Inactivity = 0f;
                IsInactive = false;
                Animator.SetBool("Pistolleft", true);
                Animator.SetBool("Aimleft", true);
                LastShoot = Time.time;
                StartCoroutine(ResetShootAnimation("Pistolleft"));
                //Rb2d.linearVelocity = new Vector2(-recoilForce, Rb2d.linearVelocity.y);
            }
            else
            {
                Inactivity = 0f;
                IsInactive = false;
                Animator.SetBool("Pistolright", true);
                Animator.SetBool("Aimright", true);
                LastShoot = Time.time;
                StartCoroutine(ResetShootAnimation("Pistolright"));
                //Rb2d.linearVelocity = new Vector2(recoilForce, Rb2d.linearVelocity.y);
            }
        }
        else
        {
            Shooting = false;
        }
        //Acuchillar
        if (Input.GetKey(KeyCode.Q) && moveX == 0.0f && Time.time > LastAttack + 0.5f && !Hidden)
        {
            if (!lookingright)
            {
                Inactivity = 0f;
                IsInactive = false;
                Animator.SetBool("Knifeleft", true);
                knife();
                LastAttack = Time.time;
                StartCoroutine(ResetShootAnimation("Knifeleft"));
            }
            else
            {
                Inactivity = 0f;
                IsInactive = false;
                Animator.SetBool("Kniferight", true);
                knife();
                LastAttack = Time.time;
                StartCoroutine(ResetShootAnimation("Kniferight"));
            }
        }

        distance = Mathf.Abs(transform.position.x - Zombie.transform.position.x);
        //Hace que el jugador parezca nervioso
        if (zombiescript.WatchPlayer)//distance < 1f)
        {
            //Debug.Log("Player watch a zombie!");
            Animator.speed = 2f;

        }
        else if (!zombiescript.WatchPlayer)
        {
            Animator.speed = defaultspeed;
        }
    }
    
    IEnumerator ResetShootAnimation(string animParameter)
    {
        yield return new WaitForSeconds(0.3f);
        Animator.SetBool(animParameter, false);
    }

    public void Shoot()
    {
        Debug.Log("Arthur is shooting");
        if (currentAmmo > 0)
        {
            Audio.PlayOneShot(Disparar);
            Vector3 direction;

            if (lookingright) direction = Vector2.right;
            else direction = Vector2.left;

            GameObject bullet = Instantiate(BulletPrefab, transform.position + direction * 0.1f, Quaternion.identity);
            bullet.GetComponent<Bullet>().SetDirection(direction);

            currentAmmo -= 1;
        }
    }

    private void knife()
    {
        Vector2 attackPosition = attackPoint.position + new Vector3((lookingright ? 1f : -1f) * offset, 0, 0);
        Collider2D[] hitzombie = Physics2D.OverlapCircleAll(attackPosition, attackRange, ZombieLayer);

        foreach (Collider2D enemy in hitzombie)
        {
            Zombie zombiescript = enemy.GetComponent<Zombie>();
            if (zombiescript != null)
            {
                Debug.Log("Arthur ve a zombie");
                //attackRange = 0.5f
                if (!zombiescript.CanBackstab)
                {
                    Debug.Log("We hit " + enemy.name);
                    zombiescript.TakeDamage(attackDamage);
                }
                else if (zombiescript.CanBackstab)
                {
                    zombiescript.TakeDamage(100);
                }
            }
        }
    }

    public void TakeDamage(int amount)
    {
        if (Death) return;
        currentHealth -= amount;
        Debug.Log("Arthur took " + amount + " damage. Current health: " + currentHealth);
        StartCoroutine(FlashRed());
        if (currentHealth <= 0)
        {
            StartCoroutine(Die());
        }
    }

    private IEnumerator FlashRed()
    {
        Color ColorDefault = SpriteRenderer.color;
        SpriteRenderer.color = Color.red;
        yield return new WaitForSeconds(0.1f);
        SpriteRenderer.color = ColorDefault;
    }

    public IEnumerator Die()
    {
        //Debug.Log("Arthur has loss");
        Death = true;
        if (!lookingright)
        {
            Animator.SetBool("Deathleft", true);
        }
        else if (lookingright)
        {
            Animator.SetBool("Deathright", true);
        }
        else if (IsInactive)
        {
            Animator.SetBool("Deathfront", true);
        }
        yield return new WaitForSeconds(0.5f);
        GetComponent<CapsuleCollider2D>().enabled = false;
        Rb2d.constraints = RigidbodyConstraints2D.FreezeAll;
    }

    private void Jump()
    {
        Rb2d.AddForce(Vector2.up * JumpForce);
    }

    private void Step()
    {
        //Rb2d.linearVelocity = new Vector2(moveX * speed, Rb2d.linearVelocity.y);
    }

    void OnDrawGizmosSelected()
    {
        
        Vector2 attackPosition = attackPoint.position + new Vector3((lookingright ? 1f : -1f) * offset, 0, 0);
        Gizmos.DrawWireSphere(attackPosition, attackRange);

        if (attackPoint == null)
            return;
    }

    private void FixedUpdate()
    {
        if (!Death)
        {
            Rb2d.linearVelocity = new Vector2(moveX * speed, Rb2d.linearVelocity.y);
        }
    }
}