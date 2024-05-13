# Задача
1. создать класс реализующий интерфейс IAttackCounter
2. метод CountUnderAttack должен считать количество пустых клеток шахматной доски находящихся под ударом шахматной фигуры
3. на данный момент должны поддерживаться две фигуры - Rook (ладья) и Bishop (слон), но желательно предусмотреть возможность расширения для других шахматных фигур
4. размер доски задается аргументом boardSize
5. начальная точка фигуры для которой считаем число клеток под ударом - startCoords
6. на доске так же находятся препятствия, их координаты передаются в метод в массиве obstacles, препятствия и клетки за ними не учитываются в числе клеток под ударом 
7. все координаты считаются начиная с 1 от левого нижнего угла
8. можно добавить дополнительные тесты для проверки в AttackSolverTest
9. задача со звездочкой: добавить еще две фигуры - коня и пешку

# Примеры
## Обозначения
O - obstacle
x - cell under attack
R - Rook
B - Bishop
. - empty cell

## Rook
### example 1
cmType=Rook, boardSize={3,2}, startCoords={1, 1}, obstacles={{2,2}, {3, 1}}
```
xO.
RxO

```
вывод: 2

## Bishop
### example 2
cmType=Bishop, boardSize={4,5}, startCoords={2, 2}, obstacles={{1,1}, {1, 3}}
```

....
...x
O.x.
.B..
O.x.

```
вывод: 3

### example 3
cmType=Bishop, boardSize={5,5}, startCoords={2, 2}, obstacles={{1,1}, {1, 3}, {3, 1}, {3, 3}}
``` 
.....
...O.
x.x..
.B...
x.x..
```
вывод: 4
