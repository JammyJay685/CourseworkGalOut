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
        if (Input.GetButtonDown("Fire1")){
            Shoot();
        }
    }
    void Shoot(){
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