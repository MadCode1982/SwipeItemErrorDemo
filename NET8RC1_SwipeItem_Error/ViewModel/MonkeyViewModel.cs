using NET8RC1_SwipeItem_Error.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace NET8RC1_SwipeItem_Error.ViewModel
{
    public class MonkeyViewModel
    {
        public ObservableCollection<Monkey> Monkeys { get; set; }

        public MonkeyViewModel()
        {
            Monkeys = new ObservableCollection<Monkey>
            {
                new Monkey{ Name = "Baboon", Desc = "Baboons"},
                new Monkey{ Name = "Capuchin Monkey", Desc = "Capuchin Monkeys"},
                new Monkey{ Name = "Blue Monkey", Desc = "Blue Monkeys"},
                new Monkey{ Name = "Squirrel Monkey", Desc = "Squirrel Monkeys"},
                new Monkey{ Name = "Golden Lion Tamarin", Desc = "Golden Lion Tamarins"},
            };
        }

        public ICommand DeleteCommand => new Command<Monkey>(DeleteMonkey);

        void DeleteMonkey(Monkey monkey)
        {
            if (Monkeys.Contains(monkey))
                Monkeys.Remove(monkey);
        }
    }
}
