using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMechanics : MonoBehaviour
{
    // Основные параметры
    public float SpeedMove; // Скорость персонажа
    public float JumpPower; // Сила прыжка

    // Параметры геймплея для персонажа
    private float GravityForce; // Сила гравитации
    private Vector3 VectorMove; // направление движения персонажа

    // Ссылки на компоненты
    private CharacterController ch_Controller;
    private Animator ch_animator;
    // Start is called before the first frame update
    void Start()
    {
        ch_Controller = GetComponent<CharacterController>();
        ch_animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        CharacterMove();
    }
    // Метод для перемещения
    private void CharacterMove()
    {
        VectorMove = Vector3.zero;
        VectorMove.x = Input.GetAxis("Horizontal") * SpeedMove;
        VectorMove.z = Input.GetAxis("Vertical") * SpeedMove;


        ch_Controller.Move(VectorMove * Time.deltaTime); // Метод передвежения по направлению
    }
 
 }
