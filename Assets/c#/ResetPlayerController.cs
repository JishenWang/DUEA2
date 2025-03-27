using UnityEngine;

public class ResetPlayerController : MonoBehaviour
{
    // 必须手动拖拽赋值
    [Header("必须设置")]
    public Transform playerTransform;

    // 自动记录的初始值
    private Vector3 initialPosition;
    private Vector3 initialScale;
    private Quaternion initialRotation;

    void Start()
    {
        if (playerTransform == null)
        {
            Debug.LogError("未分配Player对象！请检查脚本：" + gameObject.name);
            return;
        }

        // 自动记录初始状态
        initialPosition = playerTransform.position;
        initialScale = playerTransform.localScale;
        initialRotation = playerTransform.rotation;

        Debug.Log("已记录初始状态：位置=" + initialPosition);
    }

    // 公开给UI按钮调用的方法
    public void ExecuteReset()
    {
        if (playerTransform == null)
        {
            Debug.LogError("Player对象丢失！");
            return;
        }

        playerTransform.position = initialPosition;
        playerTransform.localScale = initialScale;
        playerTransform.rotation = initialRotation;

        Debug.Log("Player已重置", playerTransform);
    }
}