using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class TextRan : MonoBehaviour
{
    public TMP_Text textComponent; // Ссылка на компонент текста
    public float speed = 0.5f;    // Скорость смены цвета

    private float _hue = 0f;

    void Update()
    {
        if (textComponent == null) return;

        // Увеличиваем значение оттенка (от 0 до 1)
        _hue += Time.deltaTime * speed;

        // Если значение больше 1, сбрасываем (зацикливаем)
        if (_hue > 1f) _hue = 0f;

        // Преобразуем HSV в обычный RGB цвет
        // (Оттенок, Насыщенность 100%, Яркость 100%)
        textComponent.color = Color.HSVToRGB(_hue, 1f, 1f);
    }
}
