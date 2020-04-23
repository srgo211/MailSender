using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TestWPFramework2.MVVM;
using TestWPFramework2.Command;

namespace TestWPFramework2.ViewModel
{
    internal class MainViewModel : ViewModelBase
    {

        #region [Collection]
        private ObservableCollection<MyListClass> _КоллекцияВсехДанных;

        public ObservableCollection<MyListClass> КоллекцияВсехДанных
        {
            get => _КоллекцияВсехДанных;
            private set => Set(ref _КоллекцияВсехДанных, value);
        }
        #endregion

        #region [Command]
     
        public ICommand ДобавитьДанные { get; set; }
        public ICommand УдалитьДанные { get; set; }

        #endregion

        #region [Variable - Переменные ]
        //ИД
        private string _id;
        public string id { get { return _id; } set { _id = value; OnPropertyChanged(); } }

        //Установка имени + обновление символов
        private string _Name = "Любой текст";
        public string Name
        {
            get => _Name;
            //set => Set(ref _Text, value);

            set
            {
                if (Set(ref _Name, value))
                    OnPropertyChanged(nameof(TextLight));

            }

        }

        //кол-во символов
        public string TextLight
        {
            get
            {
                if (Name != null) return Name.Length.ToString();
                return "0";
            }
        }

        #endregion

        /// <summary>
        /// Конструктор Модели представления
        /// </summary>
        public MainViewModel()
        {

            КоллекцияВсехДанных = new ObservableCollection<MyListClass>(ЛистДанных());
            
            ДобавитьДанные = new MyICommand(ДобавитьКолВсехДанныхМетод);
            УдалитьДанные = new MyICommand(УдалитьИзКолВсехДанныхМетод);
        }


        #region Методы реализации

        public List<MyListClass> ЛистДанных()
        {
            List<MyListClass> studentsLits = new List<MyListClass>();

            for (int i = 0; i < 100; i++)
            {
                MyListClass student = new MyListClass();
                student.id = i.ToString();
                student.name = "Name-" + i;
                
                studentsLits.Add(student);
            }
            return studentsLits;
        }


        private MyListClass _ПараметрыДанных;
        public MyListClass ПараметрыДанных
        {
            get
            {
                return _ПараметрыДанных;
            }
            set
            {
                _ПараметрыДанных = value;
                OnPropertyChanged();
                if (_ПараметрыДанных != null)
                {
                    Name = ПараметрыДанных.name;
                    id = ПараметрыДанных.id.ToString();
                   
                }
            }
        }




        public void ДобавитьКолВсехДанныхМетод()
        {
           
                MyListClass student = new MyListClass();
                student.id = id;
                student.name = Name;

                КоллекцияВсехДанных.Add(student);

                id = String.Empty;
                Name = String.Empty;

                //IsShowdialog = false;
            
        }

        public void УдалитьИзКолВсехДанныхМетод()
        {
            if (ПараметрыДанных != null)
            {
                КоллекцияВсехДанных.Remove(ПараметрыДанных);
                Name = String.Empty;
                id = String.Empty;

            }
        }
        #endregion
    }

    public class MyListClass
    {

        public string id { get; set; }

        public string name { get; set; }

    }

}
