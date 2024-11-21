using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveCamera : MonoBehaviour
{
    public GameObject coll;
    public GameObject coll2;
    private float time = 1f;
    private float speed = 3f;

    public new Camera camera;

    public float x;
    public float y;
    private void OnTriggerEnter2D(Collider2D other){
        
        Vector3 targetPosition = new Vector3(x, y, camera.transform.position.z); 

        while (Vector3.Distance(camera.transform.position, targetPosition) > 0.01f)
        {
            camera.transform.position = Vector3.Lerp(camera.transform.position, targetPosition, speed * Time.deltaTime); 
        }

        camera.transform.position = targetPosition;

        StartCoroutine(wait());
    }

    IEnumerator wait(){

        yield return new WaitForSeconds(time);
        
        coll.SetActive(true);
        coll2.SetActive(false);
    }
}
