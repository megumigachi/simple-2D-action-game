using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    protected Animator animator;

    protected virtual void Start()
    {
        animator = GetComponent<Animator>();
    }

    public virtual void Hurt()
    {
        animator.SetTrigger(AnimParam.Hurt);
    }

    public void Death()
    {
        Destroy(gameObject);
    }

}
