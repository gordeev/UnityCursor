using UnityEngine;
using UnityEngine.UI;

public class InteractiveCursor : MonoBehaviour
{
    public Image cursorImage; // UI-элемент для спрайта курсора
    public float clickScaleFactor = 0.8f; // Коэффициент уменьшения при клике (например, 0.8)

    private Vector2 originalSize; // Исходный размер курсора
    private Camera mainCamera;

    void Start()
    {
        // Сохраняем исходный размер курсора
        originalSize = cursorImage.rectTransform.sizeDelta;

        // Устанавливаем горячую точку в левый верхний угол
        cursorImage.rectTransform.pivot = new Vector2(0, 1);

        // Скрываем системный курсор
        Cursor.visible = false;

        // Назначаем основную камеру автоматически
        mainCamera = Camera.main;
    }

    void Update()
    {
        // Обновляем позицию курсора
        Vector2 cursorPos;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(
            cursorImage.canvas.transform as RectTransform,
            Input.mousePosition,
            cursorImage.canvas.worldCamera,
            out cursorPos
        );
        cursorImage.rectTransform.anchoredPosition = cursorPos;

        // Проверка нажатия мыши с использованием Raycast
        if (Input.GetMouseButtonDown(0)) // Проверяем клик
        {
            Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                // Уменьшаем курсор при клике на объект
                cursorImage.rectTransform.sizeDelta = originalSize * clickScaleFactor;
            }
        }
        else if (Input.GetMouseButtonUp(0)) // Проверяем отпускание мыши
        {
            // Возвращаем курсор к исходному размеру
            cursorImage.rectTransform.sizeDelta = originalSize;
        }
    }
}
