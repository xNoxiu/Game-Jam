using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveCamera : MonoBehaviour
{
    private float speed = 3f;
    public new Camera camera;

    public float x;
    public float y;
    private void OnTriggerEnter2D(Collider2D other){
        if (other.gameObject.CompareTag("Player")){
            Vector3 targetPosition = new Vector3(x, y, camera.transform.position.z);

            camera.transform.position = Vector3.Lerp(camera.transform.position, targetPosition, speed * Time.deltaTime);

            camera.transform.position = targetPosition;
        }
    }
}
