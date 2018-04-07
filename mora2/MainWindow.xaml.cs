using System;
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
using System.Media;

namespace mora2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public class Gameboard
    {
        public List<string> positions { get; private set; }  //property value associated with an instance
       
        public Gameboard()                                 //constructor create instances of the classes
        {
            positions = new List<string>();
        }


        List<string> update(List<string> places)
        {
            List<string> positions = new List<string>();
            return positions;
        }
        
        public  void StartPrintboard(Brush[]colours, Ellipse[]places)
        {
            for (int i = 0; i < places.Length; i++)
            {
                places[i].Fill = colours[0];

            }
        }


    }

    public class Cow
    {
        public List<string> CowSelection { get; set; }
        public string[] CowList { get; set; }
        public List<string> DeadCows { get; private set; }

        public Cow()
        {
            CowSelection = new List<string>(23);
            CowList = ["C1", "C2", "C3", "C4", "C5", "C6", "C7", "C8", "C9", "C10", "C11", "C12", "C13", "C14", "C15", "C16", "C17", "C18", "C19", "C20", "C21", "C22", "C23", "C24"];
        }

        public void InitialPlacementOfCows()
        {
            while (/*Player1 or Player2 is engaged*/ )
            {
                int HowManyCowsHaveBeenPlaced = 0;

                if (/*Player Selects A Position*/)
                {
                    if (HowManyCowsHaveBeenPlaced < CowSelection.Count+1)
                    {
                        CowSelection.Add(CowList[HowManyCowsHaveBeenPlaced++]); //The cows that have been placed on the board are moved from CowList to CowSelection
                        CowList.SetValue("x", HowManyCowsHaveBeenPlaced); //Sort of like tells that a certain cow is no longer available for selection
                    }

                    if (/*Player attempts to place cow that's not available for placement*/)
                    {
                        MessageBox.Show("The cow that you've chosen has already been used. Please choose another cow.");
                    }
                }
                
            }
        }

        int Position(string cow) //Position starting from 1 counted from top left corner of board to bottom right corner of board 
        {
            for (int counter = 0; CowSelection[counter] != cow; counter++)
            {
                if (CowSelection[counter] == cow) return CowSelection[counter].ElementAt(1);
            }
            return 0;
        }

        bool IsCowAlive(string cow)
        {
            for (int counter = 0; counter < CowSelection.Count+1; counter++)
            {
                if (CowSelection[counter] == cow)
                {
                    return true;
                }
            }
            return false;
        }

        bool IsMoveValid(int position)
        {
            int counter = 0;
            while (position != Position(CowSelection[counter]) && counter < CowSelection.Count+1)
            {
                if (position == Position(CowSelection[counter]))
                {
                    return true;
                }
                counter++;
            }
           
            return false;
        }

        void Move(string cow, int position)
        {
            if (IsMoveValid(position) == true)
            {
                //I am a stub
            }
        }

        void Fly(string cow, int position)
        {
            if (IsMoveValid(position) == true)
            {
                //I am a stub
            }

        }

        bool IsMill()
        {
            //I am a stub
        }

        void Shoot (string cow, int position)
        {
            if (IsCowAlive(cow) == true)
            {
                CowSelection.Remove(cow);
                DeadCows.Add(cow);
            }
            else
            {
                MessageBox.Show("The selected cow cannot be executed. Please choose a different cow to kill.");
            }
        }


    }
    public class Players
    {
        string name;
        List<string> placement = new List<string>();
        List<string> Mills = new List<string>();
        int numberofcows;
    }
    public partial class MainWindow : Window
    {
        BitmapImage carBitmap =new BitmapImage(new Uri("pack://application:,,,/1200px-Morabaraba_board.svg.png"));

        public MainWindow()
        {
            InitializeComponent();
            board.Source = carBitmap;
            Brush [] colourme = { Brushes.Yellow, Brushes.Blue, Brushes.Green};
            Ellipse[] positions = { a1, a4, a7, b2, b4, b6, c3, c4, c5, d1, d2, d3, d5, d6, d7, e3, e4, e5, f2, f4, f6, g1, g4, g7 };
            Gameboard gamingstart = new Gameboard();
            gamingstart.StartPrintboard(colourme, positions);
            Players firstplayer = new Players();
            Players secondplayer = new Players();

        }
    }
}
