﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Shapes;
using WpfAtletiMVC.Models;

namespace WpfAtletiMVC.Views
{
    /// <summary>
    /// Logica di interazione per DettaglioAtletaView.xaml
    /// </summary>
    public partial class DettaglioAtletaView : Window
    {
        Discipline model = new Discipline();

        private ObservableCollection<Disciplina> _discipline;
        public ObservableCollection<Disciplina> discipline
        {
            get
            {
                return _discipline;
            }
            set
            {
                _discipline = value;
            }
        }

        public DettaglioAtletaView()
        {
            InitializeComponent();
            discipline = new ObservableCollection<Disciplina>(model.getAll());
            this.DataContext = this;

        }

        //comando per la chiusura di una finestra
        private void Ok_Click(object sender, RoutedEventArgs e)
        {
            //con questo comando comandiamo la chiusura di una finestra
            Close();
        }

        private void Annulla_Click(object sender, RoutedEventArgs e)
        {
            //con questo comando comandiamo la chiusura di una finestra
            Close();
        }
    }
}
