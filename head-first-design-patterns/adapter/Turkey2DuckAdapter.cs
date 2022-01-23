using System;
using System.Collections.Generic;
using System.Text;

namespace adapter
{
    public class Turkey2DuckAdapter : IDuck
    {
        readonly ITurkey Turkey;

        public Turkey2DuckAdapter(ITurkey turkey)
        {
            Turkey = turkey;
        }

        public void Fly()
        {
            for (int i = 0; i < 5; i++)
            {
                Turkey.Fly();
            }
        }

        public void Quack()
        {
            Turkey.Gobble();
        }
    }
}
