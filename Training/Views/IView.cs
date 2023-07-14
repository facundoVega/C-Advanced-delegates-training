﻿using FieldValidatorAPI.FieldValidators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Views
{
    public interface IView
    {
        void RunView();
        IFieldValidator FieldValidator { get; }
    }
}
