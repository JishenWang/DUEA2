using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class MoveLeft : MonoBehaviour
{
    public Transform player;          // 要移动的Player对象
    public float moveDistance = 1f;   // 每次移动的距离

    private Button button;

    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(MovePlayerLeft);
    }

    void MovePlayerLeft()
    {
        if (player != null)
            player.Translate(Vector3.left * moveDistance);
    }
}
