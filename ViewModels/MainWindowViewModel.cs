using CV19.Infrastructure.Commands;
using CV19.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;

namespace CV19.ViewModels
{
    internal class MainWindowViewModel : ViewModel
    {





        //private int _SelectedPageIndex;
        //public int SelectedPageIndex
        //{
        //    get => _SelectedPageIndex;
        //    set => Set(ref _SelectedPageIndex, value);
        //}
        //public ICommand ChangeTabIndexCommand { get; }
        //private void OnChangeTabIndexCommandExecuted(object p)
        //{
        //    if (p is null) return;
        //    SelectedPageIndex += Convert.ToInt32(p);
        //}
        //private bool CanChangeTabIndexCommandExecute(object p) => _SelectedPageIndex >= 0;




        #region Заголовок окна

        private string _Title = "Анализ статистики COVID-19";

        public string Title
        {
            get => _Title;
            set => Set(ref _Title, value);
        }
        #endregion

        #region Cтатус программы
        private string _Status = "Готово!";
        public string Status { get => _Status; set => Set(ref _Status, value); }
        #endregion

        #region Комманда закрытие окна

        public ICommand CloseApplicationCommand { get; }
        private void OnCloseApplicationCommandExecuted(object p)
        {
            Application.Current.Shutdown();
        }
        private bool CanCloseApplicationCommandExecute(object p) => true;
        #endregion





        public MainWindowViewModel()
        {
            CloseApplicationCommand = new LambdaCommand(OnCloseApplicationCommandExecuted, CanCloseApplicationCommandExecute);


            //ChangeTabIndexCommand = new LambdaCommand(OnChangeTabIndexCommandExecuted, CanChangeTabIndexCommandExecute);

            //    #endregion

            //    var data_points = new List<DataPoint>();

            //    for (var x = 0d; x <= 360; x += 0.1)
            //    {
            //        const double to_rad = Math.PI / 180;
            //        var y = Math.Sin(x * to_rad);

            //        data_points.Add(new DataPoint { XValue = x, YValue = y });
            //    }

            //    TestDataPoints = data_points;



            //}
        }
    }
}