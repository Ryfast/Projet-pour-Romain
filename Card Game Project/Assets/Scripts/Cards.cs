using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cards : MonoBehaviour
{
    public GameManager gameManager;

    private float move = 0.1f;
    private float zoom = 0.2f;

    private Vector3 vPositionInitial;
    private Vector3 vPosition;
    private Vector3 vScaleInitial;
    private Vector3 vScale;
    public Vector3 maPosition;

    // Start is called before the first frame update
    void Start()
    {
        vPositionInitial = gameObject.transform.position;
        vPosition = vPositionInitial;

        vScaleInitial = gameObject.transform.localScale;
        vScale = vScaleInitial;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseOver()
    {
        gameObject.transform.position = new Vector3(vPosition.x + (3 - maPosition.x) * move, vPosition.y + move, vPosition.z - move);
        gameObject.transform.localScale = new Vector3(vScale.x + zoom, vScale.y + zoom, vScale.z);
    }

    private void OnMouseExit()
    {
        gameObject.transform.position = new Vector3(vPositionInitial.x, vPositionInitial.y, vPositionInitial.z);
        gameObject.transform.localScale = new Vector3(vScaleInitial.x, vScaleInitial.y, vScaleInitial.z);
    }
}
