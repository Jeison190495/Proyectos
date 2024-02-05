using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Parcial3.Model
{
    public class ComentariosX 
    {
        [PrimaryKey, AutoIncrement] 
        public int Id { get; set; }
       public string Name { get; set; }
        public string Description { get; set; }
        public string Email { get; set; }
    }
}