# Exam

### Task 1

- What is OOP
- Что такое ООП?
- OOP чист?

---
### Task 2

- What is Class? What is the difference between class and Object?
- Что такое класс? В чем разница между классом и объектом?       
- Класс чист? Фарқи байни класс ва объект чӣ аст?      
---
### Task 3   

- What do you know about Fields and Properties? 
- Что вы знаете о Поле и Свойство?
- Шумо дар бораи Fields and Properties чӣ медонед?          
---
### Task 4   

- What is Constructor?
- Что такое конструктор?
- Конструктор чист?
---
### Task 5              
- What is Encapsulation?
- Что такое инкапсуляция?   
- Инкапсуляция чист?     
---
### Task 6                          
- What do you know about access modifiers?
- Что вы знаете о модификаторах доступа?
- Шумо дар бораи access modifiers чӣ медонед?

---

### Task 7

Create a `Math` class with : 

1. Public methods
    - `double Abs(double value);`
    - `float Abs(float value);`
    - `int Abs(int value);`
    - `double Pow(double x, double y);`
    - `double Sqrt(int d);`
    - `int Max(int val1, int val2);`
    - `int Min(int val1, int val2);`

2. Const fields
    - `const double PI = 3.14;`
    - `const double E = 2.71;`

---

### Task 8

In this task, you will create a `Post` class with the following properties and fields:

- `Title` : string
- `Description` : string
- `likeCount` : int
- `Comments` : List< string>  
- `isPublished` : bool

The `Post` class should have the following functionalities:

1. `Publish()` method:
   - Display the message `"The post is published."`
   - Set `IsPublished` to `true`.
---
2. `Like()` method:
   - Increment the `LikeCount` property by 1.
---
3. `Comment(string message)` method:
   - Add the comment `message` to the `Comments` list.
---
4. `Program.cs` :
   - Create a list type of `Post`.
   - Create 5 `Post` objects and add them to the list of posts.
   - Use a `foreach` loop to print the information of all posts,   
  following the format: `"{Title} – {Description} – number of Likes: {LikeCount}"`.
  
After testing and finishing methods
   - create a public repository in self `Github`
   - name your project with this format `MyExam`

---

В этой задаче вы создадите класс `Post` со следующими свойствами:

- `Title` : string
- `Description` : string
- `LikeCount` : int
- `Comments` : List< string>  
- `IsPublished` : bool

Класс `Post` должен иметь следующие функциональные возможности:

1. Метод `Publish()`:
   - Отображение сообщения `"The post is published."`.
   - Установите для параметра `IsPublished` значение `true`.
---
2. Метод `Like()`:
   - Увеличьте свойство `LikeCount` на 1.
---
3. Метод `Comment(string message)`:
   - Добавьте комментарий `message` в список `Comments`.
---
4. `Program.cs`:
   - Создайте список типа `Post`.
   - Создайте 5 объектов `Post` и добавьте их в список posts.
   - Используйте цикл `foreach` для печати информации обо всех posts.
  в формате: `"{Title} – {Description} – number of Likes: {LikeCount}"`.
  
После тестирования и доводки методов
   - создать публичный репозиторий на `Github`.
   - назовите свой проект в этом формате `MyExam`.
   --- 

Дар ин вазифа шумо класси `Post`-ро бо хосиятҳои зерин месозед:

- `Title`: string
- `Description`: string
- `LikeCount`: int
- `Comments` : LIst< string>
- `IsPublished`: bool

Класси `Post` бояд дорои функсияҳои зерин бошад:

1. Метод `Publish()`:
   - Паёми `"The post is published."`-ро нишон диҳaд.
   - `IsPublished` -ро ба `true` таъин кунед.
---
2. Метод `Like()`:
   - `LikeCount`-ро 1-тo зиёд кунед.
---
3. Метод `Comment(string message)`:
   - `message`-ро ба рӯйхати `Comments` илова кунед.
---
4. `Program.cs`:
   - Рӯйхати навъи `Post` созед.
   - 5 объекти `Post` созед ва онҳоро ба рӯйхати навъи `Post` илова кунед.
   - Барои чоп кардани маълумот дар бораи ҳама паёмҳо(posts) `foreach`-ро истифода баред. Дар формати зерин бароред: `"{Title} – {Description} – number of Likes: {LikeCount}"`.
  
Пас аз санҷидан ва дуруст кардани методхо
   - дар `Github` як репозитория эҷод кунед.
   - лоиҳаи худро дар ин формат `MyExam` номгузорӣ кунед.