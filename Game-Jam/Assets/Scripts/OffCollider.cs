using UnityEngine;

public class OffCollider : MonoBehaviour
{
    public GameObject toOffTriCam;
    public GameObject toOffTrigger;
    public GameObject toOnTriCam;
    public GameObject toOnTrigger;
    private void OnTriggerEnter2D(Collider2D other){
        if (other.gameObject.CompareTag("Player")){
            toOffTriCam.SetActive(false);
            toOnTriCam.SetActive(true);
            toOffTrigger.SetActive(false);
            toOnTrigger.SetActive(true);
        }
    }
}
