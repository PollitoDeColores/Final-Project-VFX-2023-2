using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class Camera_Script : MonoBehaviour
{
    [SerializeField] float speedH = 2.0f;
    [SerializeField] float speedV = 2.0f;
    [SerializeField] float speed = 10.0f;

    [Header("Materials")]
    [SerializeField] Material ChromaAb;
    [SerializeField] Material FocalBlur; 

    [Header("PostPro")]
    [SerializeField] Renderer PostProEffects;

    [Header("Color Changing Things")]
    [SerializeField] ParticleSystem AuraColor;
    [SerializeField] ParticleSystem ParticlesColor;
    [SerializeField] Material Aura;

    private float yaw = 0.0f;
    private float pitch = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        yaw += speedH * Input.GetAxis("Mouse X");
        pitch -= speedV * Input.GetAxis("Mouse Y");

        transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);

        float xDir = Input.GetAxis("Horizontal");
        float yDir = Input.GetAxis("Vertical");
        Vector3 moveDir = new Vector3(xDir, 0.0f, yDir);

        transform.position += moveDir * Time.deltaTime * speed; 
    }
}
