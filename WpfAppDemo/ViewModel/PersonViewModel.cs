using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfAppDemo.Model;

namespace WpfAppDemo.ViewModel
{
    class PersonViewModel
    {

        public ObservableCollection<PersonModel> _Person = new ObservableCollection<PersonModel>();
        public ObservableCollection<PersonModel> Person
        {
            get
            {
                if (_Person.Count <= 0)
                {
                    _Person.Add(new PersonModel("Person1"));
                    _Person.Add(new PersonModel("Person2"));
                    _Person.Add(new PersonModel("Person3"));
                    _Person.Add(new PersonModel("Person4"));
                }
                return _Person;
            }
        }

        public PersonViewModel()
        {

           
            


        }
    }
}
