using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Linker.Items
{
    // Класс комбинационного узла (Меню)
    // Может содержать подменю или меню
    public class Menu : MenuComponent
    {
        // Храним потомков
        private ArrayList _menuComponents = new ArrayList();
        public string Name { get; }
        public string Description { get; }

        // С каждым меню связывается название и описание
        public Menu(string Name, string Description)
        {
            this.Name = Name;
            this.Description = Description;
        }

        public override void Add(MenuComponent _menuComponent)
        {
            _menuComponents.Add(_menuComponent);
        }

        public override void Remove(MenuComponent _menuComponent)
        {
            _menuComponents.Remove(_menuComponent);
        }

        public override MenuComponent GetChild(int i)
        {
            return (MenuComponent)_menuComponents[i];
        }

        public override void Print()
        {
            Console.WriteLine($"{Name}\n\t{Description}\n----------------");
            IEnumerator enumerator = _menuComponents.GetEnumerator();
            while (enumerator.MoveNext())
            {
                MenuComponent menuComponent = (MenuComponent)enumerator.Current;
                menuComponent.Print();
            }
        }

        IEnumerator enumerator = null;
        public override IEnumerator CreateIterator()
        {
            if (enumerator == null)
                enumerator = _menuComponents.GetEnumerator();
            return enumerator;
        }
    }
}
