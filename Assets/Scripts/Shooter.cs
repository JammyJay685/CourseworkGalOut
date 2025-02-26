using UnityEngine;

public class Shooter : MonoBehaviour
{
    // The variables that control the weapons
    public float range = 100f;
    public static float damage = 10f;
    public float fireRate = 15f;
    public Camera fpsCam;
    // Update is called once per frame
    void Update()
    {
        // If mouse button 1 is being held down, shoot
        if (Input.GetButtonDown("Fire1")){
            Shoot();
        }
    }
    void Shoot(){
        // Checks in a striaght line within range whether or not the object hit is a "Target" if so, remove the damage variable from the gobal "Health" variable
        RaycastHit hitInfo;
        if (Physics.Raycast(fpsCam.transform.position,fpsCam.transform.forward,out hitInfo, range)){
            Debug.Log("Hit: " + hitInfo.transform.name);
            Target target = hitInfo.transform.GetComponent<Target>();
            if (target!= null){
                target.TakeDamage(damage);
            }
        }
    }
}
// Jamie