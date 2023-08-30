using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Animator animator;

    [SerializeField]
    private float moveSpeed=5f;
    // Start is called before the first frame update
    void Start()
    {
        animator=GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(GameManager.instance.isGameOver==false)
        {
              if(Input.GetKey(KeyCode.LeftArrow))
              {
                 Vector3 currentScale=transform.localScale;
                 transform.localScale=new Vector3(-Mathf.Abs(currentScale.x),currentScale.y,currentScale.z);
                 transform.position+=Vector3.left*moveSpeed*Time.deltaTime;
                 animator.SetBool("isRunning",true);
             }
             else if(Input.GetKey(KeyCode.RightArrow))
             {
                Vector3 currentScale=transform.localScale;
                transform.localScale=new Vector3(Mathf.Abs(currentScale.x),currentScale.y,currentScale.z);
                transform.position+=Vector3.right*moveSpeed*Time.deltaTime;
                animator.SetBool("isRunning",true);
             }
             else
             {
                animator.SetBool("isRunning",false);
             }
        }
        else
        {
            animator.SetBool("isRunning",false);
        }
    }
    
    public void GetPoop()
    {
        GetComponent<SpriteRenderer>().color=new Color(0.75f,0.45f,0f);
    }
}
