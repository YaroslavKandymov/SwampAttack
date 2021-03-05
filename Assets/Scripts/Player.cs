﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]

public class Player : MonoBehaviour
{
    [SerializeField] private int _health;
    [SerializeField] private List<Weapon> _weapons;
    [SerializeField] private Transform _shootPoint;

    private Weapon _currentWeapon;
    private int _currentHealth;
    private Animator _animator;

    private void Start()
    {
        _animator = GetComponent<Animator>();
        _currentHealth = _health;
        _currentWeapon = _weapons[0];
    }

    
    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            _currentWeapon.Shoot(_shootPoint);
        }
    }
}
