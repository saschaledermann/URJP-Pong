using UnityEngine;

public class PlayerInput : MonoBehaviour, IPaddleInput
{
    [SerializeField] private bool isRightPlayer;
    
    public float GetInput() => Input.GetAxis(isRightPlayer ? "Vertical2" : "Vertical");
}
