Тестовое задание

При выполнении задания был использован ChatGPT

Задание выполнено за неделю

-Создана тайл мэп карта 

-В правой нижней половине экрана следующие кнопки:
Выстрел (тратит патрон)
Инвентарь - место в котором отображается наличие предметов, каждый предмет в отдельной ячейке)
Джойстик в левом нижнем углу экрана (управляет перемещением персонажа)
Удалить предмет из рюкзака (При нажатии на предмет в рюкзаке, появляется кнопка удалить, после нажатия предмет пропадает)
-В слоте инвентаря содержится следующая визуальная информация: иконка предмета (меняется в зависимости от предмета), количество предметов в стаке (если один - не отображается количество)

-Управление персонажем:
персонаж двигается по направлению джойстика
Умеет стрелять при нажатии кнопки выстрел
у персонажа есть полоса здоровья над головой(при 0 здоровья погибает)
если персонаж подходит близко к предмету, предмет появляется в инвентаре

При старте сессии появляются 3 монстра в рандомных местах на карте
У них также шкала здоровья над головой(умирают при 0 здоровья)
при приближение игрока в зону видимости монстра - монстр приближается к игроку и атакует
с монстра выпадает предмет после смерти

Сохранение сделано на f5(создает json save_ файл), загрузка происходит автоматом при наличии json файла в PersistentDataPath
