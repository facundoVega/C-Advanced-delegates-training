﻿using FieldValidatorAPI.FieldValidators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training.Models;

namespace Training.Views
{
    public class WelcomeUserView: IView
    {
        User _user = null;

        public IFieldValidator FieldValidator => null;

        public WelcomeUserView(User user)
        {
            _user = user;
        }

        public void RunView()
        {
            Console.Clear();
            CommonOutputText.WriteMainHeading();
            CommonOutputFormat.ChangeFontColor(FontTheme.Success);
            Console.WriteLine($"Hi {_user.FirstName}!!{Environment.NewLine}Welcome to the Cycling club!!");
            CommonOutputFormat.ChangeFontColor(FontTheme.Default);
            Console.ReadKey();
        }
    }
}
