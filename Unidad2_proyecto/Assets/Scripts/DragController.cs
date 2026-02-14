using UnityEngine;
using UnityEngine.EventSystems;

public class DragController : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public static GameObject myDraggableSprite;
    Vector3 startPosition;
    float zDistanceToCamera;
    Vector3 touchOffset;
    Camera cam;

    void Start()
    {
        cam = Camera.main;
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        myDraggableSprite = gameObject;
        startPosition = transform.position;

        zDistanceToCamera = Mathf.Abs(startPosition.z - cam.transform.position.z);

        touchOffset = startPosition - cam.ScreenToWorldPoint(
            new Vector3(eventData.position.x, eventData.position.y, zDistanceToCamera));
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = cam.ScreenToWorldPoint(
            new Vector3(eventData.position.x, eventData.position.y, zDistanceToCamera))
            + touchOffset;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        myDraggableSprite = null;
        touchOffset = Vector3.zero;
    }
}