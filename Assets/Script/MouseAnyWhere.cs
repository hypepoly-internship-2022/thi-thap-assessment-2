
using UnityEngine;

public class MouseAnyWhere : MonoBehaviour
{
    public Vector3 mousePosition;
    public Vector3 worldPosition;

    private bool checkCLick = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    void OnMouseDown() {
        checkCLick = true;
    }

    void OnMouseUp() {
        checkCLick = false;
    }


    void cubeMove(){
        mousePosition = Input.mousePosition;
        mousePosition.z = Camera.main.nearClipPlane + 7; 

        worldPosition =Camera.main.ScreenToWorldPoint(mousePosition);

        transform.position = new Vector3(worldPosition.x, 1, worldPosition.z);
    }

    // Update is called once per frame
    void Update()
    {
        if(checkCLick == true){
            cubeMove();
        }
    }
}
