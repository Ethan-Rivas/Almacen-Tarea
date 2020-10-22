﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Almacén
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            page_frame.Content = new Products();
        }

        // Muestra la página de carga de productos
        private void MenuItem_AddProduct(object sender, RoutedEventArgs e)
        {
            page_frame.Content = new AddProduct();
        }
        // Muestra la página de lista de productos
        private void MenuItem_Products(object sender, RoutedEventArgs e)
        {
            page_frame.Content = new Products();
        }

        // Muestra la página de carga de marcas
        private void MenuItem_AddBrand(object sender, RoutedEventArgs e)
        {
            page_frame.Content = new AddBrand();
        }
        // Muestra la página de lista de marcas
        private void MenuItem_Brands(object sender, RoutedEventArgs e)
        {
            page_frame.Content = new Brands();
        }

        // Muestra la página de carga de modelos
        private void MenuItem_AddModel(object sender, RoutedEventArgs e)
        {
            page_frame.Content = new AddModel();
        }
        // Muestra la página de lista de modelos
        private void MenuItem_Models(object sender, RoutedEventArgs e)
        {
            page_frame.Content = new Models();
        }

        // Muestra la página de carga de usuarios
        private void MenuItem_AddUser(object sender, RoutedEventArgs e)
        {
            page_frame.Content = new AddUser();
        }
        // Muestra la página de lista de usuarios
        private void MenuItem_Users(object sender, RoutedEventArgs e)
        {
            page_frame.Content = new Users();
        }

        // Muestra la página de carga de proveedores
        private void MenuItem_AddProvider(object sender, RoutedEventArgs e)
        {
            page_frame.Content = new AddProvider();
        }
        // Muestra la página de lista de proveedores
        private void MenuItem_Providers(object sender, RoutedEventArgs e)
        {
            page_frame.Content = new Providers();
        }

        // Muestra la página para crear entradas
        private void MenuItem_AddEntry(object sender, RoutedEventArgs e)
        {
            page_frame.Content = new AddEntry();
        }
        // Muestra la página de lista de entradas
        private void MenuItem_Entries(object sender, RoutedEventArgs e)
        {
            page_frame.Content = new Entries();
        }

        // Muestra la página para crear salidas
        private void MenuItem_AddExit(object sender, RoutedEventArgs e)
        {
            page_frame.Content = new AddExit();
        }
        // Muestra la página de lista de salidas
        private void MenuItem_Exits(object sender, RoutedEventArgs e)
        {
            page_frame.Content = new Exits();
        }
    }
}