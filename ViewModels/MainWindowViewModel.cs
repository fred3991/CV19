using CV19.Infrastructure.Commands;
using CV19.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Windows.Input;
using System.Windows;
using CV19.Models;

namespace CV19.ViewModels
{
    internal class MainWindowViewModel : ViewModel
    {

        #region Перелистывание вкладок
        public ICommand ChangeTabIndexCommand { get; }
        private void OnChangeTabIndexCommandExecuted(object p)
        {
            if (p is null) return;
            SelectedPageIndex += Convert.ToInt32(p);
        }
        private bool CanChangeTabIndexCommandExecute(object p) => _SelectedPageIndex >= 0;


        private int PageCount = 9;
        private int _SelectedPageIndex;
        public int SelectedPageIndex
        {
            //get => _SelectedPageIndex;

            get { if (_SelectedPageIndex > PageCount || _SelectedPageIndex < 0) { return _SelectedPageIndex = 0; } else { return _SelectedPageIndex; } } // нихуя я умный

            set => Set(ref _SelectedPageIndex, value);
        }
        #endregion

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

        #region Тестовые данные для графиков
        private IEnumerable<DataPoint> _TestDataPoints;
        public IEnumerable<DataPoint> TestDataPoints { get => _TestDataPoints; set => Set(ref _TestDataPoints, value); }
        private IEnumerable<DataPoint> _TestDataPoints2;
        public IEnumerable<DataPoint> TestDataPoints2 { get => _TestDataPoints2; set => Set(ref _TestDataPoints2, value); }
        #endregion

        public MainWindowViewModel()
        {

            #region Комманды-лямбда комманды в приложении
            CloseApplicationCommand = new LambdaCommand(OnCloseApplicationCommandExecuted, CanCloseApplicationCommandExecute);
            ChangeTabIndexCommand = new LambdaCommand(OnChangeTabIndexCommandExecuted, CanChangeTabIndexCommandExecute);
            #endregion
            //
            // Шляпный код
            //
            var data_points = new List<DataPoint>();
            var data_points2 = new List<DataPoint>();
            for (var x = 0d; x <= 360; x += 0.1)
            {
                const double to_rad = Math.PI / 180;
                var y = Math.Sin(x * to_rad);
                data_points.Add(new DataPoint { XValue = x, YValue = y });
            }
            TestDataPoints = data_points;
            for (var x = 0d; x <= 350; x += 0.1)
            {
                const double to_rad = Math.PI / 180;
                var y = Math.Cos(x * to_rad);
                data_points2.Add(new DataPoint { XValue = x, YValue = y });
            }
            TestDataPoints2 = data_points2;
        }
    }
}