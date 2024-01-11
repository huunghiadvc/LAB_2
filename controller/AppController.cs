using System;
using Lab_2.model;
using Lab_2.service;
using LAB_2a.view;

namespace LAB_2a.controller
{
    public class AppController
    {
        static bool isLogin = false;
        static string? input;
        public static void Control()
        {
            if (isLogin == false)
            {
                isLogin = SubController.LoginController();
            }
            else
            {
                SubController.ServiceController();
            }
        }
    }
}