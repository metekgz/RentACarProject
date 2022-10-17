﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace Business.Abstract
{
   public interface IColorService
    {
        List<Color> GelAll();
        Color GetById(int colorId);
    }
}