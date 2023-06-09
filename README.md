# Опис розв'язків

## Їжачок тест (Iizha4ockTest.cs)

В цьому завданні спочатку я розібрав наслідки кожної з трьох видів зустрічей (для кожного з кольорів) і дійшов до висновку, що операції або не змінюють різницю між не необхідними кольорами (коли ми робимо зустріч для отримання необхідного кольору) або змінюють різницю між їжачками не необхідних кольорів на 3 (збільшуючи, або зменшуючи).

Далі я визначив умови існування розв'язку. Як було підмічено в умові, якщо є їжачки лише одного кольору (і він не необхідний нам), то розв'язків, звичайно, немає. Крім того, кінцевим необхідним результатом є рівність кількості їжаків не необхідного кольору (0 та 0), і, враховуючи наслідки кожної з трьох видів зустрічей, якщо різниця у кількості їжаків не необхідного кольору не буде кратна трьом, то розв'зків у задачі не буде - ми не зможемо прирівняти їх кількість.

Основною задачею є перевірити умови існування розв'язку та прирівняти кількість їжаків не необхідного кольору (зробити їх різницю рівною нулю), після чого просто парувати їжаків не необхідного кольору, поки їхня кількість не зменшиться до нуля.

На початку своєї роботи метод, отримуючи вхідні дані, відходить від оперування кількостями їжаків конкретного кольору до оперування "кількостями їжаків необхідного кольору" та першою та другою групою їжаків "не необхідного кольору" - для зручності подальших обрахунків.

Далі метод перевіряє умови розв'язку задачі і, у разі їх виконання переходить до основного циклу своєї роботи мета якого це звести різницю між їжаками не необхідного кольору до нуля, інкрементуючи на кожному етапі лічильних зустрічей їжаків. Після зведення різниці до нуля залишається лише додати до лічильника зустрічей кількість їжаків не необхідного кольору що залишилась (можна обрати будь яку з двох - на цьому етапі вони рівні) та повернути результат.

## Sudoku test (SudokuTests.js)

Алгоритм вирішення даної задачі не є складним. Необхідно лише перевірити 9 рядків, 9 стовпців та 9 квадратів 3*3 на унікальність чисел в кожній з даних послідовностей. 

На першому етапі функція проходиться по 9 рядках та 9 стовпцях. Кожну з 9 ітерацій створюється Set (набір унікальних елементів) для стовпців та рядків. Далі у внутрішньому циклі перебираються значення стовпця та рядка. Якщо елемент рівний нулю (за умовою задачі це порожня клітинка - недійсний розв'язок) або вже є в Set-і (тобто повторюється) то повертаємо false.

На другому етапі відбувається перевірка дев'ятиквадратів 3*3. Логіка програми схожа на перший етап. Відрізнається лише спосіб отримання унікального набору чисел: там це були рядки та стовпці, а тут - квадрати.

В кінці функція повертає true: якщо ми не повернули false до цього, то розв'язок пройшов валідацію
