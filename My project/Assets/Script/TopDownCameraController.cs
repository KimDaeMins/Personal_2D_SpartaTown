using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Tilemaps;

public class TopDownCameraController : MonoBehaviour
{
    [SerializeField]
    GameObject _player;


    Vector3 _cameraPosition = new Vector3(0, 0, 0);
    public float _cameraMoveSpeed = 3.0f;
    float _lxMax, _lxMin;
    float _lyMax, _lyMin;

    // Start is called before the first frame update
    void Start()
    {
        GameObject go = GameObject.Find("Grid");
        if (go == null)
            return;

        Tilemap tm = Util.FindChild<Tilemap>(go , "Dark" , true);

        float height = Camera.main.orthographicSize;
        float width = height * Screen.width / Screen.height;
        _lxMax = tm.cellBounds.xMax - width;
        _lxMin = tm.cellBounds.xMin + width;
        _lyMax = tm.cellBounds.yMax - height;
        _lyMin = tm.cellBounds.yMin + height;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position , _player.transform.position + _cameraPosition , Time.deltaTime * _cameraMoveSpeed);
        float clampX = Mathf.Clamp(transform.position.x, _lxMin , _lxMax);
        float clampY = Mathf.Clamp(transform.position.y, _lyMin , _lyMax);
        transform.position = new Vector3(clampX , clampY , -10.0f);
    }
}
