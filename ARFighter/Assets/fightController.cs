using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fightController : MonoBehaviour
{
	// Start is called before the first frame update

	public Transform enemyTarget;
	static Animator anim;

	public static bool mvBack = false;

	public static bool mvFWD = false;

	public static fightController instance;

	public static bool isAttacking = false;

	private Vector3 direction;

    void Awake()
	{
        if(instance==null)
		{
			instance = this;

		}
	}

	void Start()
    {
		anim = GetComponent<Animator>();

        
    }

	// Update is called once per frame
	void Update()
	{

		direction = enemyTarget.position - this.transform.position;
		direction.y = 0;
		this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.LookRotation(direction), 0.3f);
		if (anim.GetCurrentAnimatorStateInfo(0).IsName("fight_idle")){

			isAttacking = false;
		}

			
		if (isAttacking == false)
		{
			if (mvBack == true)
			{
				anim.SetTrigger("mvBack");
			}

			else
			{
				anim.SetTrigger("idle");
				anim.ResetTrigger("mvBack");
			}


			if (mvFWD == true)
			{
				anim.SetTrigger("mvBack");
			}
			else if (mvBack == false)
			{
				anim.SetTrigger("idle");
				anim.ResetTrigger("mvFWD");
			}
		}
    }

    public void punch()
	{
		isAttacking = true;
		anim.ResetTrigger("idle");
		anim.SetTrigger("punch");


	}

    public void kick ()
	{
		isAttacking = true;
		anim.ResetTrigger("idle");
		anim.SetTrigger("kick");
	}

    public void react()
	{
		isAttacking = true;
		anim.ResetTrigger("idle");
		anim.SetTrigger("react");
	}
}


