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


        public MainViewModel()
        {
            MyList = new ObservableCollection<MyListClass>(GetDataStudent());
            SaveStudentCMD = new MyICommand(SaveStudent);
            DeleteStudentCMD = new MyICommand(DeleteStudent);
        }





        public ICommand CreateRecipientCommand { get; }
        public ICommand SaveStudentCMD { get; set; }
        public ICommand DeleteStudentCMD { get; set; }

        #region Обработка текста Text
        private string _Name = "Любой текст";

        public string Name
        {
            get => _Name;
            //set => Set(ref _Text, value);

            set
            {
                if (Set(ref _Name, value))
                    OnPropertyChanged(nameof(TextLight));
                    //OnPropertyChanged(nameof(MyList));
            }

        }
        #endregion



        public string TextLight
        {
            get
            {
                if (Name != null) return Name.Length.ToString();
                return "0";
            }
        }

        #region [Collection]
        private ObservableCollection<MyListClass> _MyList;

        public ObservableCollection<MyListClass> MyList
        {
            get => _MyList;
            private set => Set(ref _MyList, value);
        }
        #endregion


        #region [Variable]
        private string _id;
        public string id { get { return _id; } set { _id = value; OnPropertyChanged(); } }

        //private string _Name;
       // public string Name { get { return _Name; } set { _Name = value; OnPropertyChanged(); } }
        #endregion


        #region [Command]
        public ICommand ShowDialogAddStudentCMD { get; set; }

        #endregion


        public List<MyListClass> GetDataStudent()
        {
            List<MyListClass> studentsLits = new List<MyListClass>();

            for (int i = 0; i < 10; i++)
            {
                MyListClass student = new MyListClass();
                student.id = i.ToString();
                student.name = "Name-" + i;
                
                studentsLits.Add(student);
            }
            return studentsLits;
        }

        private MyListClass _selectedItemStudent;
        public MyListClass SelectedItemStudent
        {
            get
            {
                return _selectedItemStudent;
            }
            set
            {
                _selectedItemStudent = value;
                OnPropertyChanged();
                if (_selectedItemStudent != null)
                {
                    Name = SelectedItemStudent.name;
                    id = SelectedItemStudent.id.ToString();
                   
                }
            }
        }




        public void SaveStudent()
        {
           
                MyListClass student = new MyListClass();
                student.id = new Random().Next(0,100).ToString();
                student.name = Name;

                MyList.Add(student);

                id = String.Empty;
                Name = String.Empty;

                //IsShowdialog = false;
            
        }

        public void DeleteStudent()
        {
            if (SelectedItemStudent != null)
            {
                MyList.Remove(SelectedItemStudent);
                Name = String.Empty;
                id = String.Empty;

            }
        }

    }

    public class MyListClass
    {

        public string id { get; set; }

        public string name { get; set; }

    }

}
