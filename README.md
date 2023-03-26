# Zenject Practice

### 1 Обработка для управления движением персонажа

https://qiita.com/4_mio_11/items/4306732bc47780802b74
````
Имплементация регистрации 1 интерфейса инпута

PlayerInput содержит поле [Inject] Inputtable  

Container.Bind<IInputtable>().To<InputFromKeyboard>().AsSingle();

В PlayerInput - Inputtable предоставляется экземляр класса InputFromKeyboard

Даже если вы хотите использовать другой класс Input во время разработки, все, что вам нужно сделать, 
это заменить InputFromKeyboard внутри класса Installer. Очень удобно, не так ли?
````

### 2 UniRx + Unit Test + Zenject + MVP
https://matcha-choco010.net/2019/08/24/unity-mvrp-zenject-multiscene/

````
UniRx - Реактивные свойства / события которые мы можем обсёрвить и реактить на изменения
IObservable<>
IReadOnlyReactiveProperty<int>
IntReactiveProperty
Subscribe

MVP - MP : OOP, V : MB

Zenject - переход между сценами (переброс значений hp - 2 способа см статью 
(из коробки Zenject и Project Context) + базовые биндинги
IfNotBound - When this is added to a binding and there is already a binding with the 
given contract type + identifier, then this binding will be skipped

Unit Tests - база создания тестов
````