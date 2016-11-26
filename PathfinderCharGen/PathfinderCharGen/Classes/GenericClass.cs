using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reactive;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using Reactive.Bindings;
using System.Diagnostics;

namespace ReactiveLeveling.Classes
{
    public class GenericClass
    {
        public ReactiveProperty<int> classFortSave = new ReactiveProperty<int>(0);
        public ReactiveProperty<int> classRefSave = new ReactiveProperty<int>(0);
        public ReactiveProperty<int> classWillSave = new ReactiveProperty<int>(0);
        public ReactiveProperty<int> classFirstAttackBonus = new ReactiveProperty<int>(0);

        public virtual void ClassLevels(uint level)
        {
            Debug.WriteLine("Generic ClassLevels was called");
        }
    }
}
