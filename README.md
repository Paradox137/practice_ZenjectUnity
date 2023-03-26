# Zenject Practice

#### 1 Обработка для управления движением персонажа

https://qiita.com/4_mio_11/items/4306732bc47780802b74
````
Имплементация регистрации 1 интерфейса инпута

PlayerInput содержит поле [Inject] Inputtable  

Container.Bind<IInputtable>().To<InputFromKeyboard>().AsSingle();

В PlayerInput - Inputtable предоставляется экземляр класса InputFromKeyboard

Даже если вы хотите использовать другой класс Input во время разработки, все, что вам нужно сделать, 
это заменить InputFromKeyboard внутри класса Installer. Очень удобно, не так ли?
````