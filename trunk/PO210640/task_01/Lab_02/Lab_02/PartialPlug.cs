﻿using System;
using System.Windows;

namespace Lab_02;

public partial class MainWindow : Window
{
    private Guid _guid;
}

public partial class App : Application
{
    public Guid Guid { get; set; }
}
