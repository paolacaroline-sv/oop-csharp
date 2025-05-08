using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using abstract_notes.Entities.Enum;


namespace abstract_notes.Entities
{
    abstract class Shape
    {
        public Colors Color { get; set; }

        public Shape() { }
        public Shape(Colors color)
        {
            Color = color;
        }

        public abstract double Area();
    }
}
