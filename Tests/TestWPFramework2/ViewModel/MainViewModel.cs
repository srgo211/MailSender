using GalaSoft.MvvmLight;

namespace TestWPFramework2.ViewModel
{

    public class MainViewModel : ViewModelBase
    {

        private string _Title = "�������� ������ ��� ��������";

        public string Title { get => _Title; set => Set(ref _Title, value); }


        private string _Text = "�������� ������ ��� ��������";
        public string Text {
            get => _Title;
            
            //���� ��-�� ����������
            //if (set => Set(ref _Title, value))
                    
        }


        private int _TextLight;
        public int TextLight { get => _TextLight; set => Set(ref _TextLight, value); }




        public MainViewModel()
        {
 
        }
    }
}