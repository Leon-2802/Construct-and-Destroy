using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rocketWest : MonoBehaviour
{
    public GameObject explosion;
    [SerializeField] private float closeRadius = 2f;
    [SerializeField] private float middleRadius = 3.5f;
    [SerializeField] private float farRadius = 5f;
    private bool closeHit = false;
    private bool middleHit = false;

    private void OnTriggerEnter(Collider other) {
        if(other.CompareTag("playerEast") || other.CompareTag("Wall") || other.CompareTag("towerEast") || other.CompareTag("coverEast")) {
            explode();
        }
    }

    private void explode()
    {
        Instantiate(explosion, transform.position, transform.rotation);
        Collider [] closeColliders = Physics.OverlapSphere(transform.position, closeRadius);
        Collider[] middleColliders = Physics.OverlapSphere(transform.position, middleRadius);
        Collider[] farColliders = Physics.OverlapSphere(transform.position, farRadius);

        foreach(Collider nearbyObject in closeColliders)
        {
            if (nearbyObject.CompareTag("playerEast") || nearbyObject.CompareTag("towerEast") || nearbyObject.CompareTag("coverEast")) {
                if (nearbyObject.CompareTag("playerEast")) {
                    nearbyObject.GetComponent<hitProcessingEast>().Hurt(15);
                    closeHit = true;
                }
                else if (nearbyObject.CompareTag("towerEast")) {
                    nearbyObject.GetComponent<towerDamage>().damage(15);
                    closeHit = true;
                }
                else if (nearbyObject.CompareTag("coverEast")) {
                    nearbyObject.GetComponent<towerDamage>().damage(15);
                    closeHit = true;
                }
            }
        }

        foreach(Collider nearbyObject in middleColliders)
        {
            if (nearbyObject.CompareTag("playerEast") || nearbyObject.CompareTag("towerEast") || nearbyObject.CompareTag("coverEast")) {
                if(closeHit == false) {
                    if(nearbyObject.CompareTag("playerEast")) {
                        nearbyObject.GetComponent<hitProcessingEast>().Hurt(10);
                        middleHit = true;
                    } 
                    else if (nearbyObject.CompareTag("towerEast")) {
                        nearbyObject.GetComponent<towerDamage>().damage(10);
                        middleHit = true;
                    }
                    else if (nearbyObject.CompareTag("coverEast")) {
                        nearbyObject.GetComponent<towerDamage>().damage(10);
                        closeHit = true;
                    }
                }
            }
        }

        foreach(Collider nearbyObject in farColliders)
        {
            if (nearbyObject.CompareTag("playerEast") || nearbyObject.CompareTag("towerEast") || nearbyObject.CompareTag("coverEast")) {
                if(middleHit == false && closeHit == false) {
                    if (nearbyObject.CompareTag("playerEast")) {
                        nearbyObject.GetComponent<hitProcessingEast>().Hurt(5);
                    }
                    else if (nearbyObject.CompareTag("towerEast")) {
                        nearbyObject.GetComponent<towerDamage>().damage(5);
                    }
                    else if (nearbyObject.CompareTag("coverEast")) {
                        nearbyObject.GetComponent<towerDamage>().damage(5);
                        closeHit = true;
                    }
                }
            }
        }

        Destroy(gameObject);
    }
}
