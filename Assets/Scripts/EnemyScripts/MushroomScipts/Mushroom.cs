using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mushroom : MonoBehaviour
{
    #region public
    public Transform rayCast;
    public LayerMask rayCastMask;
    public float rayCastLength;
    public float attackDistance;
    public float moveSpeed;
    public float timer;
    //public GameObject mushroom;
    #endregion

    #region private
    private RaycastHit2D hit;
    private GameObject target;
    private Animator anim;
    private float distance;
    private bool attackMode;
    private bool inRange;
    private bool cooling;
    private float intTimer;

    #endregion
    void Awake()
    {
        intTimer = timer;
        anim = GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update()
    {
        if (inRange)
        {
            hit = Physics2D.Raycast(rayCast.position, Vector2.left * rayCastLength, rayCastMask);
            //IsHit();
        }

        if (hit.collider != null)
        {
            EnemyLogic();
        }
        else if (hit.collider == null)
        {
            inRange = false;
        }
        if (inRange == false)
        {
            anim.SetBool("CanWalk", false);
            StopAttack();
        }
    }
    void EnemyLogic()
    {
        distance = Vector2.Distance(transform.position, target.transform.position);
        if (distance > attackDistance)
        {
            Move();
            StopAttack();
        } else if (attackDistance>= distance && cooling == false) 
        {
            Attack();

        }
        if (cooling)
        {
            Cooldown();
            anim.SetBool("Attack", false); 
        }
    }
    void StopAttack()
    {
        cooling = false;
        attackMode = false;
        anim.SetBool("Attack", false);
    }
    void Attack()
    {
        timer = intTimer;
        attackMode = true;
        anim.SetBool("CanWalk", false);
        anim.SetBool("Attack", true);
    }
    void Move()
    {
        anim.SetBool("CanWalk", true);
        if (!anim.GetCurrentAnimatorStateInfo(0).IsName("MushroomAttack1"))
        {
            Vector2 targetPosition = new Vector2(target.transform.position.x, target.transform.position.y);
            if (targetPosition.x > transform.position.x)
            {
                transform.rotation = Quaternion.Euler(0, 0, 0);

            }
            else 
            {
                transform.rotation = Quaternion.Euler(0, 180, 0);
            }
            
            transform.position = Vector2.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);
        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag=="Player")
        {
            target = collision.gameObject;
            inRange = true;
        }
    }
    void IsHit() 
    {
        if(distance>attackDistance)
        {
            //efekt uderzenia
            //Debug.
        }
        
    }
    void Cooldown()
    {
        timer -= Time.deltaTime;
        if(timer<=0 && cooling && attackMode)
        {
            cooling = false;
            timer = intTimer;
        }
    }
    public void TriggerCooling()
    {
        cooling = true;
    }
}
