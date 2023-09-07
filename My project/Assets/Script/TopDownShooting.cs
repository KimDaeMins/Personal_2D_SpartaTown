using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownShooting : MonoBehaviour
{
    private TopDownCharacterController _controller;
    [SerializeField] private Transform projecttileSpqwnPosition;
    private Vector2 _aimDirection = Vector2.right;

    private void Awake()
    {
        _controller = GetComponent<TopDownCharacterController>();
    }
    // Start is called before the first frame update
    void Start()
    {
        _controller.OnAttackEvent += OnShoot;
        _controller.OnLookEvent += OnAim;
    }
    private void OnAim(Vector2 newAimDirection)
    {
        _aimDirection = newAimDirection;
    }
    private void OnShoot()
    {
        CreateProjectile();
    }
    private void CreateProjectile()
    {
        float rotZ = Mathf.Atan2(_aimDirection.y , _aimDirection.x) * Mathf.Rad2Deg;

        Managers.Resource.Instantiate("Arrow", projecttileSpqwnPosition.position , Quaternion.Euler(0 , 0 , rotZ));
    }

    // Update is called once per frame
    void Update()
    {

    }
}
