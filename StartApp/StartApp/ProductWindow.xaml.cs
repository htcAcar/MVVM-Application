using System.Windows;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Windows.Controls;
using System.Linq;
using StartApp.Entities.Dtos;
using StartApp.Business;
using StartApp.Entities.Concrete;
using StartApp.ViewModels;
using System.Windows.Input;

namespace StartApp
{
    public partial class ProductWindow : Window
    {
        public ProductWindow()
        {
            InitializeComponent();      
            this.DataContext = new ProductWindowViewModel();
        }        
    }    
}
