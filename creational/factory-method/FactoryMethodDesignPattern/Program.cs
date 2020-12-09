﻿using FactoryMethodDesignPattern.SimplePizza;
using System;

namespace FactoryMethodDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(PizzaAscii.Pizza);

            var store = new NewYorkPizzaStore();

            store.OrderPizza("cheese");
            store.OrderPizza("New York Cheese Pizza");
        }
    }

    public static class PizzaAscii
    {
        public static string Pizza => "                                                      ▓▓▓▓  ▓▓▓▓▓▓▓▓▓▓                                          \r\n                                              ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒                                        \r\n                                      ▒▒▒▒▓▓▒▒▓▓▒▒▒▒▒▒▒▒▒▒▓▓▒▒▒▒▒▒▒▒▒▒▓▓                                        \r\n                                ▒▒▒▒▒▒▓▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▓▓▒▒▒▒▒▒▒▒▓▓                                        \r\n                            ▒▒▒▒▒▒▓▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▒▒▒▒▒▒▓▓▓▓                                        \r\n                        ▓▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▓▓▓▓▓▓▓▓░░░░                                      \r\n                      ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▓▓▒▒▒▒▒▒▒▒▒▒▓▓▓▓▒▒▒▒░░░░░░░░░░                                    \r\n                    ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▒▒▒▒▒▒▓▓▓▓▒▒░░░░░░░░░░▓▓▓▓▓▓▓▓                                  \r\n                ▓▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▓▓▓▓▓▓░░░░░░░░░░░░░░██▓▓▓▓▓▓▓▓▓▓                                \r\n              ▒▒▒▒▒▒▒▒▒▒▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▓▓▓▓░░░░░░░░░░░░░░░░░░▓▓▓▓▓▓▓▓▓▓▓▓░░░░                            \r\n            ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▓▓▒▒▒▒▒▒▒▒▒▒▓▓▓▓▒▒░░░░░░░░░░░░░░░░░░░░░░  ▓▓▓▓▓▓▓▓  ░░░░                            \r\n          ▒▒▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▒▒▒▒▓▓▓▓▒▒░░░░░░░░░░░░▓▓▓▓▓▓▓▓░░░░░░░░░░░░░░      ░░░░                          \r\n          ▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▓▓▓▓▒▒░░░░░░░░░░░░░░▓▓▓▓▓▓▓▓▓▓▓▓░░░░░░░░░░          ░░░░                        \r\n      ▒▒▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▓▓▓▓▒▒░░░░░░░░░░░░░░██▓▓▓▓▓▓▓▓▓▓▓▓▓▓░░░░░░░░▓▓▓▓▓▓▓▓  ░░░░░░                      \r\n    ▒▒▒▒▒▒▒▒▓▓▓▓▓▓▒▒▒▒▒▒▒▒▓▓▓▓▒▒░░░░░░░░░░░░░░░░░░██▓▓▓▓▓▓▓▓▓▓▓▓▓▓░░░░░░██▓▓▓▓▓▓▓▓▓▓  ░░░░░░                    \r\n  ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▓▓▓▓▒▒▓▓▓▓▒▒░░░░░░░░░░░░░░░░░░░░░░████▓▓▓▓▓▓▓▓░░░░░░██▓▓▓▓▓▓▓▓▓▓▓▓▓▓    ░░                    \r\n  ▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▓▓▒▒▒▒░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓    ░░░░░░                \r\n  ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▓▓▒▒░░░░░░░░▓▓▓▓▓▓▓▓░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░████▓▓▓▓▓▓▓▓░░    ░░░░░░░░              \r\n  ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▒▒░░░░░░░░▓▓▓▓▓▓▓▓▓▓▓▓░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░      ░░░░              \r\n  ▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▓▓░░░░░░░░▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓░░░░░░░░░░▓▓▓▓▓▓▓▓░░░░░░░░░░░░░░░░░░░░░░░░░░      ░░░░            \r\n  ▓▓▒▒▒▒▒▒▒▒▒▒▒▒▓▓▓▓▒▒░░░░░░░░██▓▓▓▓▓▓▓▓▓▓▓▓▓▓░░░░░░░░██▓▓▓▓▓▓▓▓▓▓░░░░░░░░░░░░░░░░░░░░░░░░░░      ░░░░          \r\n    ▓▓▓▓▓▓▓▓▓▓▓▓▒▒▒▒░░░░░░░░░░░░████▓▓▓▓▓▓▓▓░░░░░░░░██▓▓▓▓▓▓▓▓▓▓▓▓▓▓░░░░░░░░░░░░░░░░░░░░░░░░░░    ░░░░░░        \r\n      ▒▒▒▒▒▒▒▒▒▒▓▓▓▓▓▓░░░░░░░░░░░░░░████░░░░░░░░░░░░██▓▓▓▓▓▓▓▓▓▓▓▓▓▓░░░░░░░░░░░░▓▓▓▓▓▓▓▓░░░░░░░░    ░░░░        \r\n          ▒▒▒▒▒▒▓▓▓▓▓▓▓▓▓▓░░░░░░░░░░░░░░░░░░░░░░░░░░░░████▓▓▓▓▓▓▓▓░░░░░░░░░░░░▓▓▓▓▓▓▓▓▓▓▓▓░░░░░░    ░░░░░░      \r\n              ▒▒▒▒▓▓▓▓▓▓▓▓▓▓░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░████░░░░░░░░░░░░░░▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓░░░░    ░░░░░░      \r\n                  ▒▒▒▒▒▒▒▒▓▓▓▓▓▓░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░██▓▓▓▓▓▓▓▓▓▓▓▓▓▓░░░░░░    ░░░░░░    \r\n                    ▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░  ▓▓░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░████▓▓▓▓▓▓▓▓░░░░░░░░    ░░░░░░    \r\n                            ▒▒▒▒▒▒░░░░  ▓▓░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░██████░░░░░░░░░░░░    ░░░░░░    \r\n                                  ▒▒░░░░▒▒▒▒░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░  ░░░░░░░░  \r\n                                  ▒▒░░    ▒▒▒▒░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░    ░░░░░░  \r\n                                    ░░░░      ░░░░░░  ▒▒▒▒░░░░░░░░░░░░░░░░▓▓▒▒░░░░░░░░░░░░░░░░░░░░░░░░  ░░░░░░  \r\n                                    ░░░░░░      ░░░░  ░░▒▒░░░░░░░░░░░░░░▓▓▓▓▓▓▓▓░░░░░░░░░░░░░░░░░░░░░░    ░░░░  \r\n                                      ░░░░      ░░░░░░░░  ▒▒░░░░░░  ░░░░▒▒▒▒▒▒▓▓▓▓▓▓░░░░░░░░░░░░░░░░░░      ░░  \r\n                                        ░░░░    ░░░░  ░░  ░░░░░░░░  ░░░░▓▓▒▒▒▒▒▒▒▒▒▒▓▓▓▓░░░░░░░░░░░░░░░░░░░░░░  \r\n                                          ░░░░  ░░░░░░░░    ░░░░░░  ░░▒▒        ▒▒▒▒▒▒▒▒▒▒▓▓░░░░░░░░░░░░░░  ░░  \r\n                                            ░░░░░░░░▒▒      ░░░░░░░░░░░░              ▒▒▒▒▒▒░░░░  ▒▒▓▓▒▒░░  ░░  \r\n                                              ░░░░░░░░      ░░░░░░░░░░░░              ░░    ░░░░░░░░▒▒░░░░  ░░  \r\n                                              ░░░░░░▒▒        ░░░░░░░░░░                    ░░░░░░░░▒▒▒▒░░  ░░  \r\n                                                ▒▒░░░░        ░░░░  ▒▒                        ░░░░░░▒▒▒▒░░  ░░  \r\n                                                ░░░░░░        ░░░░░░░░                        ░░░░▒▒▒▒▒▒░░  ░░  \r\n                                                  ░░░░        ░░░░                            ▒▒  ░░    ░░  ░░  \r\n                                                  ░░░░        ░░░░                            ░░  ░░    ░░  ░░  \r\n                                                  ░░          ▒▒░░                            ░░  ░░    ▒▒░░░░  \r\n                                                  ░░            ░░                            ░░  ░░      ░░░░  \r\n                                                                ░░                            ░░░░░░      ░░░░  \r\n                                                                ░░                              ░░░░      ░░░░  \r\n                                                                ░░                              ░░░░      ░░░░  \r\n                                                                ░░                                        ░░░░  \r\n                                                                ░░                                        ░░░░  \r\n                                                              ░░  ░░                                    ░░░░░░░░\r\n                                                              ░░░░                                      ░░      \r\n                                                                ░░                                    ░░░░      \r\n                                                                                                      ░░░░░░  ░░\r\n                                                                                                        ░░░░░░  \r\n";
    }
}