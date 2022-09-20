using System;

namespace AbbreviatedSyntax
{
    class Program
    {
        public class MenuItem
        {
            public string Caption;
            public string HotKey;
            public MenuItem[] Items;
        }

        public static MenuItem[] GenerateMenu()
        {
            return new MenuItem[]
            {
                new MenuItem
                {
                    Caption = "File",
                    HotKey = "(F)",
                    Items = new MenuItem[]
                    {
                        new MenuItem
                        {
                            Caption = "New",
                            HotKey = "(N)"
                        },
                        new MenuItem
                        {
                            Caption = "Save",
                            HotKey = "(N)"
                        }
                    }
                },
                new MenuItem
                {
                    Caption = "Edit",
                    HotKey = "(E)",
                    Items = new MenuItem[]
                    {
                        new MenuItem
                        {
                            Caption = "Copy",
                            HotKey = "(C)"
                        },
                        new MenuItem
                        {
                            Caption = "Paste",
                            HotKey = "(P)"
                        }
                    }
                }
            };
        }
    }
}
