using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectilePlayer : MonoBehaviour
{
    [SerializeField] GameObject projectile;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
