using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Health : MonoBehaviour
{
    public GameObject[] hearts; //[0] [1] [2]
    private int life; //3
    private bool dead;
    // Start is called before the first frame update
    private void Start()
    {
        life = hearts.Length; 
    }

    // Update is called once per frame
    void Update()
    {
       if(dead == true)
        {
            //gameover scene
           // Debug.Log("GAME OVER");
        }
    }

    public void TakeDamage(int dam)
    {
        if (life >= 1)
        {
            life -= dam;
            Destroy(hearts[life].gameObject);
            if (life < 1)
            {
                dead = true;
            }
        }
    }
}
