using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppDemo.Model
{
    class PersonModel
    {
        public string PersonName { get; set; }

        public PersonModel(string Name)
        {
            PersonName = Name;
        }

    }
}
