using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge
{
    class Abstraction
    {
        protected IFigure figure;

        public Abstraction(IFigure figure)
        {
            this.figure = figure;
        }

        public virtual string Draw()
        {
            return "Фигура " +  figure.DrawFigure() + " нарисована";
        }
    }
}
