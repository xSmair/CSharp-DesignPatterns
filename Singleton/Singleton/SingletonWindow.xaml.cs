using System;
using System.ComponentModel;
using System.Windows;

namespace Singleton;

public partial class SingletonWindow : Window
{
    private static SingletonWindow _instance;
    
    public static SingletonWindow Instance => _instance ??= new SingletonWindow();

    public int RandomNumber { get; }
    
    private SingletonWindow()
    {
        InitializeComponent();
        RandomNumber = new Random().Next(0, 100);
    }

    private void SingletonWindow_OnLoaded(object sender, RoutedEventArgs e)
    {
        RandomNumberLabel.Content = RandomNumber + "";
    }
}