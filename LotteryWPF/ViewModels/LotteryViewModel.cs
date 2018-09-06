using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Threading;
using System.Xml.Serialization;

namespace LotteryWPF.ViewModels
{
    
    public class LotteryViewModel : ViewModelBase
    {
        private string _infoText;
        
        private ICommand _SubmitCommand;

        private ICommand _ClearInfoCommand;
        public ICommand _deleteCommand;
        public string InfoText
        {
            get
            {
                return _infoText;
            }
            set
            {
                _infoText = value;
                NotifyPropertyChanged("InfoText");
            }
        }

        
        
        public ICommand DeletePC
        {
            get
            {
                if (_SubmitCommand == null)
                {
                    _SubmitCommand = new RelayCommand(param => this.delete(),
                        null);
                }
                return _SubmitCommand;
            }
        }
        public PC SelectedItem { get; set; }

        public ICommand ClearInfoCommand
        {
            get
            {
                if (_ClearInfoCommand == null)
                {
                    _ClearInfoCommand = new RelayCommand(param => this.clearInfo(),
                        null);
                }
                return _ClearInfoCommand;
            }
        }
        public PCListViewModel()
        {
            
            InfoText = "Demo";
            PCHelper.LoadPCList();
            ModifiedItems = new List<PC>();
            PCs = new ObservableCollection<PC>(PCHelper.PCList.PCs);
            PCHelper.isLoaded = true;
            PCs.CollectionChanged += PCs_CollectionChanged;
            foreach(var pc in PCHelper.PCList.PCs)
            {
                pc.PropertyChanged += Pc_PropertyChanged;
            }
        }

        private void Pc_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            PCHelper.PCList.PCs = PCs.ToList();
            PCHelper.SavePCList();
        }

        public List<PC> ModifiedItems { get; set; }
        private void PCs_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            //PCHelper.PCList.PCs = PCs.ToList();
            //PCHelper.SavePCList();
            if (e.NewItems != null)
            {
                foreach (PC newItem in e.NewItems)
                {
                    ModifiedItems.Add(newItem);

                    //Add listener for each item on PropertyChanged event
                    newItem.PropertyChanged += NewItem_PropertyChanged;
                }
            }

            if (e.OldItems != null)
            {
                foreach (PC oldItem in e.OldItems)
                {
                    ModifiedItems.Add(oldItem);

                    oldItem.PropertyChanged -= NewItem_PropertyChanged;
                }
            }
        }

        private void NewItem_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            PCHelper.PCList.PCs = PCs.ToList();
            PCHelper.SavePCList();
        }

        private void updatLogHandler(object sender, EventArgs e)
        {
           
        }
        private void changeExportPath()
        {
            
        }
        private void changeSessionLogPath()
        {
           
        }
        private void clearInfo()
        {
            InfoText = "";
        }
        private void delete()
        {
            if (SelectedItem != null)
            {
                PCs.Remove(SelectedItem);
                PCHelper.PCList.PCs = PCs.ToList();
                PCHelper.SavePCList();
            }
        }
    }
}
