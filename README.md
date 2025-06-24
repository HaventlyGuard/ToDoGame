# 🎮 ToDo RPG - Gamified Productivity App

**Совмещаем продуктивность и геймификацию в стильном WPF-приложении**

![.NET Version](https://img.shields.io/badge/.NET-4.8-blue)
![WPF](https://img.shields.io/badge/WPF-MVVM-purple)
![PostgreSQL](https://img.shields.io/badge/PostgreSQL-Planned-336791)

## 🌟 О проекте

ToDo RPG превращает рутинные задачи в увлекательную RPG-игру:
- ✅ Выполняешь задачи → получаешь **XP и коины**
- 🛒 Покупаешь снаряжение в магазине
- 🧙‍♂️ Прокачиваешь персонажа
- 📅 Планируешь задачи в интерактивном календаре

## 🛠 Технический стек

### 🖥️ **Ядро приложения**
- **Язык**: C# 9.0
- **Платформа**: .NET Framework 4.8
- **Архитектура**: MVVM (Model-View-ViewModel)
- **Шаблоны проектирования**:
  - RelayCommand для обработки действий UI
  - INotifyPropertyChanged для биндинга данных
  - Dependency Injection (в планах)

### 🎨 **WPF и UI компоненты**
```xml
<Application.Resources>
    <ResourceDictionary>
        <ResourceDictionary.MergedDictionaries>
            <ResourceDictionary Source="Styles/ButtonStyles.xaml"/>
            <ResourceDictionary Source="Styles/TextBoxStyles.xaml"/>
        </ResourceDictionary.MergedDictionaries>
    </ResourceDictionary>
</Application.Resources>
```

### 🗃️ **Работа с данными**
- **Планируемое хранилище**: PostgreSQL с Entity Framework Core
- **Схема данных** (планируется):
  ```csharp
  public class User
  {
      public int Id { get; set; }
      public string Name { get; set; }
      public int Level { get; set; }
      public int Experience { get; set; }
      public int Coins { get; set; }
      public List<InventoryItem> Inventory { get; set; }
  }
  ```

### 📐 **Макет и структура**
- **Основной контейнер**: Grid с динамическими строками/столбцами
- **Навигация**: StackPanel с кастомными ToggleButton
- **Адаптивность**: ViewBox для масштабирования
- **Закругленные углы**: Border и CornerRadius

## 🏆 Основные функции

### 🏠 **Домашняя страница**
-Показывает текущие задачи на день

### 🛒 **Магазин снаряжения** ( в планах )
- Категории: Оружие, Броня, Артефакты
- Система улучшений (Upgrade)
- Премиум-валюта (в планах)

### 📅 **Планировщик задач** (в планах)
- Drag-and-drop интерфейс
- Повторяющиеся задачи
- Уведомления (Windows Toast)

## 🚀 Запуск проекта

1. **Требования**:
   - Visual Studio 2019+
   - .NET Framework 4.8 Developer Pack

2. **Сборка**:
   ```bash
   git clone https://github.com/your-username/todo-rpg-wpf.git
   cd todo-rpg-wpf
   start TodoRPG.sln
   ```

3. **Конфигурация БД** (будущая реализация):
   ```json
   {
     "ConnectionStrings": {
       "Default": "Host=localhost;Database=todo_rpg;Username=postgres;Password=1234"
     }
   }
   ```

## 📈 Планы развития

### 🔮 Ближайшие обновления
- [ ] Интеграция с PostgreSQL
- [ ] Cloud Sync через REST API
- [ ] Система достижений

### 🎮 Игровые механики
- [ ] Таланты и скиллы
- [ ] PvP-режим (сравнение продуктивности)
- [ ] Гиблое задание (ежедневный вызов)

---

💡 **Особенности реализации**:
- Полностью кастомный UI без стандартных контролов
- Оптимизированная работа с Binding
- Расширяемая архитектура для новых модулей

