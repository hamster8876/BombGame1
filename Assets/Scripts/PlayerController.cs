using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float translation;
    private float rotation;
    public Animation animator;

    private void Start()
    {
        Animator animator = GetComponent<Animator>();
    }

    void Update()
    {
        translation = Input.GetAxis("Vertical") * 10f;
        rotation = Input.GetAxis("Horizontal") * 100f;

        transform.Translate(0, 0, translation * Time.deltaTime);
        transform.Rotate(0, rotation * Time.deltaTime, 0);

        animator.SetBool("walk", true);
    }
}
