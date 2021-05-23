using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    [SerializeField]
    private float movementSpeed;
    bool Rapidfire = false;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HandleMovementIput();
        HandleRotationInput();
        HandleShoot();
    }

    // For Buttery Smoothness
    void HandleMovementIput()
    {
        float _horizontal = Input.GetAxis("Horizontal");
        float _Vertical = Input.GetAxis("Vertical");

        Vector3 _movementSpeed = new Vector3(_horizontal, 0, _Vertical);
        transform.Translate(_movementSpeed * movementSpeed * Time.deltaTime, Space.World);
    }

    void HandleRotationInput()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if(Physics.Raycast(ray, out hit))
        {
            transform.LookAt(new Vector3(hit.point.x, transform.position.y, hit.point.z));
        }
    }

    void HandleShoot()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            PlayerGun.Instance.Shoot();
        }
    }

    
}
