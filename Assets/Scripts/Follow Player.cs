using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    public GameObject player;
    public GameObject thiscamera;
    [SerializeField] private Vector3 offect = new Vector3(0, 5, -9);
    // Start is called once before the first execution of Update after the MonoBehaviour is created


    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offect;
    }
}
