using UnityEngine;

public class DragonBehaviour : MonoBehaviour
{
    private Animator mAnimator;
    public Transform otherDragon;
    public float attackDistance = 0.25f;
    private bool isAttacking = false;

    void Start()
    {
        mAnimator = GetComponent<Animator>();
    }

    void Update()
    {
        if (mAnimator == null || otherDragon == null)
            return;

        float distance = Vector3.Distance(transform.position, otherDragon.position);
        if (distance < attackDistance && !isAttacking)
        {
            mAnimator.SetTrigger("TrAttack");
            isAttacking = true;
        }
        else if (distance >= attackDistance && isAttacking)
        {
            mAnimator.SetTrigger("TrIdle");
            isAttacking = false;
        }
    }
}
