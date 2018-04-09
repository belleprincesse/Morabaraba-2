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
        public string[] stringpositions;  //property value associated with an instance
        public Brush[] colourpositions { get; private set; }
        public Gameboard(Brush[] colourpositions)                                 //constructor create instances of the classes
        {
            stringpositions = new string[] { "A1", "D1", "G1", "B2", "D2", "F2", "C3", "D3", "E3", "A4", "B4", "C4", "E4", "F4", "G4", "C5", "D5", "E5", "B6", "D6", "F6", "A7", "D7", "G7" };
            this.colourpositions = colourpositions;


        }

        public void placements(Brush whichplayer, string whereisthecow)
        {
            int index = -1;
            for (int i = 0; i < stringpositions.Length + 1; i++)  //check valid position
            {
                if (stringpositions[i] == whereisthecow)
                {
                    index = i;
                    break;
                }
            }
            if (index != -1)
            {
                Brush whatcolour = colourpositions[index];
                if (whatcolour == Brushes.Yellow)
                {
                    colourpositions[index] = whichplayer;
                }
                else if (whatcolour == whichplayer)
                {
                    MessageBox.Show("You already occupy that position. Please select another placement");
                }
                else
                {
                    MessageBox.Show("Your oppponent occupies that space. Please select another placement");
                }

            }
            else
            {
                MessageBox.Show("Please re-enter a valid position");
            }



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

        public Cow()
        {
            CowSelection = new List<string>(23);
            CowList = ["C1","C2","C3","C4","C5","C6","C7","C8","C9","C10", "C11", "C12", "C13", "C14", "C15", "C16", "C17", "C18", "C19", "C20", "C21", "C22", "C23", "C24"];
        }

        public void InitialPlacementOfCows()
        {
            while (/*Player1 or Player2 is engaged*/ )
            {
                int HowManyCowsHaveBeenPlaced = 0;

                if (/*Player Selects A Position*/)
                {
                    if (HowManyCowsHaveBeenPlaced < 24)
                    {
                        CowSelection.Add(CowList.[HowManyCowsHaveBeenPlaced++]); //The cows that have been placed on the board are moved from CowList to CowSelection
                        CowList.SetValue("x", HowManyCowsHaveBeenPlaced); //Sort of like tells that a certain cow is no longer available for selection
                    }
                    
                }
                if (/*Player attempts to place cow that's not available for placement*/)
                {
                    MessageBox.Show("The cow that you've chosen has already been used. Please choose another cow.");
                }
            }
        }

        int Position (string cow) //Position starting from 1 counted from top left corner of board to bottom right corner of board 
        {
            for (int counter = 0; CowList[counter] != cow; counter++)
            {
                if (CowList[counter] == cow) return CowList[counter].ElementAt(1);
            }
            return 0;
        }

        bool isMoveValid(string position)
        {
            // I am a stub!
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
        Brush[] colourme = { Brushes.Yellow, Brushes.Blue, Brushes.Green };
        Brush[] colourpositions = { Brushes.Yellow, Brushes.Yellow, Brushes.Yellow, Brushes.Yellow, Brushes.Yellow, Brushes.Yellow, Brushes.Yellow, Brushes.Yellow, Brushes.Yellow, Brushes.Yellow, Brushes.Yellow, Brushes.Yellow, Brushes.Yellow, Brushes.Yellow, Brushes.Yellow, Brushes.Yellow, Brushes.Yellow, Brushes.Yellow, Brushes.Yellow, Brushes.Yellow, Brushes.Yellow, Brushes.Yellow, Brushes.Yellow, Brushes.Yellow };
        Players firstplayer = new Players();
        Players secondplayer = new Players();
        Ellipse[] positions1;

        public MainWindow()
        {
            InitializeComponent();
            board.Source = carBitmap;
            Ellipse[] positions = { a1, a4, a7, b2, b4, b6, c3, c4, c5, d1, d2, d3, d5, d6, d7, e3, e4, e5, f2, f4, f6, g1, g4, g7 };
            positions1 = positions;
            Gameboard gamingstart = new Gameboard(colourpositions);
            gamingstart.StartPrintboard(colourme, positions);

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string positionis = Convert.ToString(t1.Text);
            Gameboard gameinitalise = new Gameboard(colourpositions);
            gameinitalise.placements(Brushes.Blue, positionis);
        }
    }
}
