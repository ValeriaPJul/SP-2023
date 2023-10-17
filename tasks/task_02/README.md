# Лабораторная работа № 2

## Создание программы с графическим пользовательским интерфейсом в ОС Windows

### Цель работы

Научиться создавать простейшие приложения с графическим пользовательским интерфейсом в ОС Windows.

### Теория

Для выполнения лабораторной работы рекомендуется использовать Microsoft Visual Studio (Community Edition). Необходимо написать приложения для Windows согласно варианту и используя язык C++. Отчёт должен содержать цель работы, код программы, скриншот работы программы и вывод по лабораторной работе.

Для создания необходимого шаблона в Microsoft Visual Studio вам необходимо создать новый проект и выбрав из списка шаблонов «Классическое приложение Windows».

Весь код добавления элементов должен помещаться в ветку WM_CREATE switch’a в методе WndProc. Для добавления элемента необходимо использовать функцию CreateWindow.

Параметры этой функции следующие:

1. Тип добавляемого элемента. Используйте TEXT(“edit”) (поле для ввода текста) и TEXT(“button”) (кнопка).
2. Имя элемента/окна.
3. Стиль добавляемого элемента.
4. Позиция элемента на экране по оси X.
5. Позиция элемента на экране по оси Y.
6. Ширина элемента.
7. Высота элемента.
8. Родитель элемента. Используйте hwnd из параметров WndProc.
9. Id элемента. Используйте (HMENU) *число*. 10 И 11 параметр оставляйте NULL.

Пример использования:

``` c++
СreateWindow(TEXT("button"), TEXT("Click me!"),
            WS_VISIBLE | WS_CHILD,
            30, 40, 20, 50,
            hwnd, (HMENU)1, NULL, NULL);
```

Для обработки нажатия кнопки добавляйте код в WM_COMMAND в том же switch-блоке, проверяя id команды. Для предыдущей кнопки это будет выглядеть следующим образом:

``` c++
if (LOWORD(wParam) == 1) {
      sendMessage();
}
```

Текст добавляется в WM_PAINT следующим образом:

```c++
PAINTSTRUCT ps;
HDC hdc;
TCHAR greeting[] = _T("Hello, World!");

switch (message)
{
case WM_PAINT:
    hdc = BeginPaint(hwnd, &ps);

    TextOut(hdc,
        5, 5,
        greeting, _tcslen(greeting));

    EndPaint(hwnd, &ps);
    break;
}
```

Для полного обновления окна (перерисовки с нуля) используйте функцию

```C++
InvalidateRect(NULL, NULL, TRUE);
```

### Варианты заданий

1. Создать приложение с кнопкой и полем для ввода текста. По нажатию на кнопку приложение должно создавать всплывающее окно с введённым текстом.
2. Создать приложение с кнопкой и полем для отображения текста. По нажатию на кнопку необходимо выводить следующую букву на экран (после каждого нажатия на кнопку должна добавляться одна буква, например, после 3х нажатий на экране будет «при», после 5 – «приве»).
3. Создать приложение с тремя кнопками и полем для отображения текста. По нажатию на кнопку выводить на экран «победу» или «поражение» в зависимости от нажатой кнопки. Определять, какая кнопка будет отвечать за это случайным образом при старте приложения и после нажатия на кнопку.
4. Создать приложение с кнопкой и полем для ввода текста. По нажатию на кнопку проверять, угадал ли пользователь загаданное число.
5. Создать приложение с двумя кнопками и полем для отображения числа. По нажатию на кнопки число должно увеличиваться или уменьшаться в зависимости от нажатой кнопки.
6. Создать приложение с кнопкой и полем для отображения имени. По нажатию на кнопку необходимо показывать случайное имя из заданного в коде списка.