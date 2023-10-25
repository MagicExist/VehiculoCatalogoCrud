using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using VehiculoCatalogoCrud.Core;

namespace VehiculoCatalogoCrud.ViewModel
{
    internal class MainViewModel : ObservableObjects
    {
		private List<string> _listFabricantes;
        private RelayCommand _command;
        private MainWindow _currenWindow;

		public List<string> ListFabricantes
		{
			get { return _listFabricantes; }
			set { _listFabricantes = value; OnPropertyChanged(); }
		}

        public void nose(object paremeter) 
        {
            List<string> nuevaLista = new List<string> { "NuevoItem" };
            ListFabricantes = nuevaLista;
            ComboBox cbFabricantes = _currenWindow.cbFabricantes;
            cbFabricantes.ItemsSource = _listFabricantes;

        }

        public MainViewModel(MainWindow currentWindow)
        {
            _currenWindow = currentWindow;
            _command = new RelayCommand(nose);

        }

    }
}
