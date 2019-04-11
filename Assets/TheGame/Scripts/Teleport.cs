using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;     // ADD THIS


// Quelle: http://www.sdkboy.com/2016/12/building-daydream-controller-based-app-scratch/

[RequireComponent(typeof(Collider))]
public class Teleport : MonoBehaviour
{
    private Vector3 startingPosition;

    public Material inactiveMaterial;
    public Material gazedAtMaterial;
    public GameObject player;     // ADD THIS

    public void TeleportTo(BaseEventData data)
    {
        PointerEventData pointerData = data as PointerEventData;
        Vector3 worldPos = pointerData.pointerCurrentRaycast.worldPosition;
        Vector3 playerPos = new Vector3(worldPos.x, player.transform.position.y, worldPos.z);
        player.transform.position = playerPos;
    }
}
