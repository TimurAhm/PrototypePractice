Когда использовать:
 1. Когда конкретный тип создаваемого объекта должен определяться динамически во время выполнения
 2. Когда нежелательно создание отдельной иерархии классов фабрик для создания объектов-продуктов из параллельной иерархии классов (как это делается, например, при использовании паттерна Абстрактная фабрика)
 3. Когда клонирование объекта является более предпочтительным вариантом нежели его создание и инициализация с помощью конструктора. Особенно когда известно, что объект может принимать небольшое ограниченное число возможных состояний.

Классный паттерн, содавать прототип(копию) чего либо очень полезно и сразу приходят в голову примеры применения, допустим я достал какой-то сложный и дорогостоящий объект из бд, в следущий раз его также создавать долго и затратно, но можно создрать из него прототип и затем его хэшировать, как результат - взаимодействие с бд шустрее и производительность проекта выше.

Но важно заметить, существует 2 вида копий - поверхностная и глубокая.
