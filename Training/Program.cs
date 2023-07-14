using System;
using Training;
using Training.Views;

namespace MyApp // Note: actual namespace depends on the project name.
{

    internal class Program
    {
        delegate void LogDel(string text);

        static void Main(string[] args)
        {
            IView mainView = Factory.GetMainViewObject();
            mainView.RunView();

            Console.ReadKey();

        }



    }

   
}