
using UnityEngine;

public class MouseDrag : MonoBehaviour
{
    [SerializeField] private Vector3 mousePosition;

    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody> ();
    }
    private void OnMouseDrag() 
    {
        Vector3 mousePosition = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, Camera.main.nearClipPlane + 7);
        Vector3 objPos = Camera.main.ScreenToWorldPoint (mousePosition);
        this.transform.position = new Vector3(objPos.x, 5, objPos.z);
    }
}
