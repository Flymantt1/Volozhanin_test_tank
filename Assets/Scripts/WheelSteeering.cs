using UnityEngine;

public class WheelController : MonoBehaviour
{
    [Header("Wheel Colliders")]
    public WheelCollider frontLeftWheel;
    public WheelCollider frontRightWheel;

    [Header("Steering Settings")]
    public float maxSteerAngle = 30f;  // Максимальный угол поворота колес
    public float steerSpeed = 5f;      // Скорость поворота (плавность)

    private float targetSteerAngle;    // Текущий целевой угол поворота
    private float currentSteerAngle;   // Текущий угол поворота (для плавности)

    void Update()
    {
        // Получаем ввод с клавиатуры или геймпада (-1..1)
        float horizontalInput = Input.GetAxis("Horizontal");

        // Вычисляем целевой угол поворота
        targetSteerAngle = maxSteerAngle * horizontalInput;

        // Плавно изменяем угол поворота
        currentSteerAngle = Mathf.Lerp(currentSteerAngle, targetSteerAngle, steerSpeed * Time.deltaTime);

        // Применяем поворот к колесам
        frontLeftWheel.steerAngle = currentSteerAngle;
        frontRightWheel.steerAngle = currentSteerAngle;
    }
}
