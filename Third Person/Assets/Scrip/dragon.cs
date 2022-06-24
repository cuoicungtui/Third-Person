using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dragon : MonoBehaviour
{
    public int HP = 100;

    public Animator animator;

    public void takeDamage(int damageAmount)
    {
        HP -= damageAmount;
        if(HP <= 0)
        {
            animator.SetTrigger("die");
        }
        else
        {
            animator.SetTrigger("damage");
        }

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
