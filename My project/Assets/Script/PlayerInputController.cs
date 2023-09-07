using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputController : TopDownCharacterController
{
    private Camera _camera;
    private Animator _Animator;


    protected override void Awake()
    {
        _camera = Camera.main;
    }
    protected override void Start()
    {
        GameObject go = GameObject.Find("Player");
        _Animator = go.GetComponent<Animator>();
        NameSetting();
        CharacterSetting();
    }

    public void NameSetting()
    {
        Name = Managers.Data.UserName;
        GameObject go = GameObject.Find("Text (TMP)");
        go.GetComponent<TMP_Text>().text = Name;
    }

    public void CharacterSetting()
    {
        _Animator.runtimeAnimatorController = Managers.Data.UserAnimator;
        transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = Managers.Data.UserSprite;
    }

    public void OnMove(InputValue value)
    {
        Vector2 moveInput = value.Get<Vector2>().normalized;
        if(moveInput.y == 0 && moveInput.x == 0)
            _Animator.SetBool("isMove" , false);
        else
            _Animator.SetBool("isMove" , true);
        CallMoveEvent(moveInput);
    }
    public void OnLook(InputValue value)
    {
        Vector2 nowAim = value.Get<Vector2>();
        Vector2 worldPos = _camera.ScreenToWorldPoint(nowAim);
        nowAim = ( worldPos - (Vector2)transform.position ).normalized;

        if (nowAim.magnitude >= 0.9f)
            CallLookEvent(nowAim);
    }
    public void OnFire(InputValue value)
    {
        IsAttacking = value.isPressed;
    }
}
