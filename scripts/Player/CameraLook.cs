
using UnityEngine;
using Cinemachine;
[RequireComponent(typeof(CinemachineFreeLook))]

public class CameraLook : MonoBehaviour
{
    [SerializeField]
    private float lookspeed = 1f;

    private CinemachineFreeLook cinemachine;
    private Player playerinput;

    private void Awake()
    {
        playerinput = new Player();
        cinemachine = GetComponent<CinemachineFreeLook>();

    }


    private void OnEnable()
    {
        playerinput.Enable();
    }

    private void OnDisable()
    {
        playerinput.Disable();
    }



    // Update is called once per frame
    void Update()
    {

        Vector2 delta = playerinput.PlayerMain.look.ReadValue<Vector2>();
        cinemachine.m_XAxis.Value += delta.x * 200 * lookspeed * Time.deltaTime;
        cinemachine.m_YAxis.Value += delta.y * lookspeed * Time.deltaTime;  
    }
}
