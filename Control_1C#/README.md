# Алгоритм.

1) Объявляем первый массив (*string[] firstArray*).
2) Объявляем string array, чтобы она заполнялась набираемой через терминал информацией 
(*Console.ReadLine()*).
3) Присваеваем элементам массива (*string[] firstArray*) значения подстрок string array, 
которые мы получили через команду *Split(' ')*.
4) Выводим массив (*string[] firstArray*).
5) Объявляем второй массив (*string[] secondArray*), длина которого будет равна длине 
первого массива, введенного с помощью терминала.
6) Пишем метод заполнения второго массива (void CreatSecondArray) элементами, подходящими 
согласно условию задачи. Он принимает на вход два массива, первый массив 
из которого будет производится выборка необходимых нам элементов и пустой второй массив,
который необходимо заполнить. Выборка сделана через цикл (*for (int i = 0; i < firstArray.
Length; i++)*), в котором уточняется длина каждого элемента первого 
массива. Если он подходит, то элемент (*secondArray[digit]*) второго массива (*string[] 
secondArray*) принимает его значение.
7) Вывод итогового второго массива (*string[] secondArray*).