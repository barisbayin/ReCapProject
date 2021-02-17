using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Core.Entities;


namespace Entities.Concrete
{
    public class Color:IEntity
    {
        public int Id { get; set; }
        public string ColorName { get; set; }
    }
}
