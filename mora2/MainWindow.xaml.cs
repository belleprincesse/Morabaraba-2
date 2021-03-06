﻿using System;
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
            //stringpositions = new string [] { "A1", "D1", "G1", "B2", "D2", "F2", "C3", "D3", "E3", "A4", "B4", "C4", "E4", "F4", "G4", "C5", "D5", "E5", "B6", "D6", "F6", "A7", "D7", "G7"};
            stringpositions = new string[] { "A1", "A4", "A7", "B2", "B4", "B6", "C3", "C4", "C5", "D1", "D2", "D3", "D5", "D6", "D7", "E3", "E4", "E5", "F2", "F4", "F6", "G1", "G4", "G7" };
            this.colourpositions = colourpositions;


        }

        public void placements(Brush whichplayer, string whereisthecow)
        {
            int index = -1;

            for (int i = 0; i < stringpositions.Length; i++)  //check valid position
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

        public void updateboardvisual(Ellipse[] places, int player)   //print the changes onto the board
        {
            string output = "";
            for (int i = 0; i < places.Length; i++)
            {
                places[i].Fill = colourpositions[i];

            }
            if (player == 1)
            {
                output = "Player" + Convert.ToString(2);
            }
            else { output = "Player" + Convert.ToString(1); }

            MessageBox.Show("Please select a position on position box ", output);

        }

        public void StartPrintboard(Brush[] colours, Ellipse[] places)
        {
            for (int i = 0; i < places.Length; i++)
            {
                places[i].Fill = colours[0];

            }

        }


    }

    public class Cow
    {
        List<string> CowMills;

        public Cow ()                                 
        {
            List<List<string>> CowMills = new List<List<string>>();

        }

        public void Millchecker(List<string> cowpositions)
        {
          
            cowpositions.Sort();
            for(int i = 0; i<cowpositions.Count; i++)
            {
              if(cowpositions[i]=="A1")
                {
                    if(cowpositions[i + 1] == "D1" && cowpositions[i + 2] == "G1")
                    {
                        List<List<string>> myList = new List<List<string>>();
                        myList.Add(new List<string> { "A1", "D1", "G1" });

                    }else if(cowpositions[i + 1] == "A4" && cowpositions[i + 2] == "A7")
                    {
                        List<List<string>> myList = new List<List<string>>();
                        myList.Add(new List<string> { "A1", "A4", "A7" });
                    }
                    else if (cowpositions[i + 1] == "B2" && cowpositions[i + 2] == "C3")
                    {
                        List<List<string>> myList = new List<List<string>>();
                        myList.Add(new List<string> { "A1", "B2", "C3" });
                    }

                }
                if (cowpositions[i] == "A4")
                {
                    if (cowpositions[i + 1] == "B4" && cowpositions[i + 2] == "C4")
                    {
                        List<List<string>> myList = new List<List<string>>();
                        myList.Add(new List<string> { "A4", "B4", "C4" });

                    }

                }
                if (cowpositions[i] == "A7")
                {
                    if (cowpositions[i + 1] == "D7" && cowpositions[i + 2] == "G7")
                    {
                        List<List<string>> myList = new List<List<string>>();
                        myList.Add(new List<string> { "A7", "D7", "G7" });

                    }
                    else if (cowpositions[i + 1] == "B6" && cowpositions[i + 2] == "C5")
                    {
                        List<List<string>> myList = new List<List<string>>();
                        myList.Add(new List<string> { "A7", "B6", "C5" });
                    }

                }
                if (cowpositions[i] == "B2" )
                {
                    if (cowpositions[i + 1] == "D2" && cowpositions[i + 2] == "F2")
                    {
                        List<List<string>> myList = new List<List<string>>();
                        myList.Add(new List<string> { "B2", "D2", "F2" });

                    }
                    else if (cowpositions[i + 1] == "B4" && cowpositions[i + 2] == "B6")
                    {
                        List<List<string>> myList = new List<List<string>>();
                        myList.Add(new List<string> { "B2", "B4", "B6" });
                    }

                }
                if (cowpositions[i] == "B6")
                {
                    if (cowpositions[i + 1] == "D6" && cowpositions[i + 2] == "F6")
                    {
                        List<List<string>> myList = new List<List<string>>();
                        myList.Add(new List<string> { "B6", "D6", "F6" });

                    }

                }
                if (cowpositions[i] == "C3")
                {
                    if (cowpositions[i + 1] == "D3" && cowpositions[i + 2] == "E3")
                    {
                        List<List<string>> myList = new List<List<string>>();
                        myList.Add(new List<string> { "C3", "D3", "E3" });

                    }
                    else if (cowpositions[i + 1] == "C4" && cowpositions[i + 2] == "C5")
                    {
                        List<List<string>> myList = new List<List<string>>();
                        myList.Add(new List<string> { "C3", "C4", "C5" });
                    }

                }
                if (cowpositions[i] == "D1")
                {
                    if (cowpositions[i + 1] == "D2" && cowpositions[i + 2] == "D3")
                    {
                        List<List<string>> myList = new List<List<string>>();
                        myList.Add(new List<string> { "D1", "D2", "D3" });

                    }

                }
                if (cowpositions[i] == "D5")
                {
                    if (cowpositions[i + 1] == "D6" && cowpositions[i + 2] == "D7")
                    {
                        List<List<string>> myList = new List<List<string>>();
                        myList.Add(new List<string> { "D5", "D6", "D7" });

                    }

                }
                if (cowpositions[i] == "E3")
                {
                    if (cowpositions[i + 1] == "E4" && cowpositions[i + 2] == "E5")
                    {
                        List<List<string>> myList = new List<List<string>>();
                        myList.Add(new List<string> { "E3", "E4", "E5" });

                    }

                }
                if (cowpositions[i] == "E4")
                {
                    if (cowpositions[i + 1] == "F4" && cowpositions[i + 2] == "G4")
                    {
                        List<List<string>> myList = new List<List<string>>();
                        myList.Add(new List<string> { "E4", "F4", "G4" });

                    }

                }
                if (cowpositions[i] == "E5")
                {
                    if (cowpositions[i + 1] == "F6" && cowpositions[i + 2] == "G7")
                    {
                        List<List<string>> myList = new List<List<string>>();
                        myList.Add(new List<string> { "E5", "F6", "G7" });

                    }

                }
                if (cowpositions[i] == "F2")
                {
                    if (cowpositions[i + 1] == "F4" && cowpositions[i + 2] == "F6")
                    {
                        List<List<string>> myList = new List<List<string>>();
                        myList.Add(new List<string> { "F2", "F4", "F6" });

                    }

                }
                if (cowpositions[i] == "G1")
                {
                    if (cowpositions[i + 1] == "G4" && cowpositions[i + 2] == "G7")
                    {
                        List<List<string>> myList = new List<List<string>>();
                        myList.Add(new List<string> { "G1", "G4", "G7" });

                    }
                    else if (cowpositions[i + 1] == "F2" && cowpositions[i + 2] == "E3")
                    {
                        List<List<string>> myList = new List<List<string>>();
                        myList.Add(new List<string> { "G1", "F2", "E3" });
                    }

                }


            }
        }
    }

    //public class Cow
    //{
    //    public List<string> CowSelection { get; set; }
    //    public string[] CowList { get; set; }
    //    public List<string> DeadCows { get; private set; }

    //    public Cow()
    //    {
    //        CowSelection = new List<string>(23);
    //        CowList = ["C1", "C2", "C3", "C4", "C5", "C6", "C7", "C8", "C9", "C10", "C11", "C12", "C13", "C14", "C15", "C16", "C17", "C18", "C19", "C20", "C21", "C22", "C23", "C24"];
    //    }

    //    public void InitialPlacementOfCows()
    //    {
    //        while (/*Player1 or Player2 is engaged*/ )
    //        {
    //            int HowManyCowsHaveBeenPlaced = 0;

    //            if (/*Player Selects A Position*/)
    //            {
    //                if (HowManyCowsHaveBeenPlaced < CowSelection.Count + 1)
    //                {
    //                    CowSelection.Add(CowList[HowManyCowsHaveBeenPlaced++]); //The cows that have been placed on the board are moved from CowList to CowSelection
    //                    CowList.SetValue("x", HowManyCowsHaveBeenPlaced); //Sort of like tells that a certain cow is no longer available for selection
    //                }

    //                if (/*Player attempts to place cow that's not available for placement*/)
    //                {
    //                    MessageBox.Show("The cow that you've chosen has already been used. Please choose another cow.");
    //                }
    //            }

    //        }
    //    }

    //    int Position(string cow) //Position starting from 1 counted from top left corner of board to bottom right corner of board 
    //    {
    //        for (int counter = 0; CowSelection[counter] != cow; counter++)
    //        {
    //            if (CowSelection[counter] == cow) return CowSelection[counter].ElementAt(1);
    //        }
    //        return 0;
    //    }

    //    bool IsCowAlive(string cow)
    //    {
    //        for (int counter = 0; counter < CowSelection.Count + 1; counter++)
    //        {
    //            if (CowSelection[counter] == cow)
    //            {
    //                return true;
    //            }
    //        }
    //        return false;
    //    }

    //    bool IsMoveValid(int position)
    //    {
    //        int counter = 0;
    //        while (position != Position(CowSelection[counter]) && counter < CowSelection.Count + 1)
    //        {
    //            if (position == Position(CowSelection[counter]))
    //            {
    //                return true;
    //            }
    //            counter++;
    //        }

    //        return false;
    //    }

    //    void Move(string cow, int position)
    //    {
    //        if (IsMoveValid(position) == true)
    //        {
    //            I am a stub
    //        }
    //    }

    //    void Fly(string cow, int position)
    //    {
    //        if (IsMoveValid(position) == true)
    //        {
    //            I am a stub
    //        }

    //    }

    //    bool IsMill()
    //    {
    //        I am a stub
    //    }

    //    void Shoot(string cow, int position)
    //    {
    //        if (IsCowAlive(cow) == true)
    //        {
    //            CowSelection.Remove(cow);
    //            DeadCows.Add(cow);
    //        }
    //        else
    //        {
    //            MessageBox.Show("The selected cow cannot be executed. Please choose a different cow to kill.");
    //        }
    //    }


    //}

    public class Players
    {
        string name;
        public List<string> placement { get; private set; }
        public List<List<string>> Mills { get; private set; }
        public int numberofcows { get; private set; }
        Brush colour;
        public Players(string playername, Brush playercolour)                                 //constructor create instances of the classes
        {
            name = playername;
            this.placement = placement;
            this.Mills = Mills;
            this.numberofcows=numberofcows;
            Brush colour = playercolour;
        }

        public void addplacementtoplayer(string position)
        {
            placement.Add(position);
        }
        
        
        public void increasecows()
        {
            numberofcows++;
        }

        public void decreasecows()
        {
            numberofcows--;
        }
        
        public void AddCowmills(List<string> onecowmill)
        {
            Mills.Add(onecowmill);
        }

        public void MinusCowmills(List<string> onecowmill)
        {
            Mills.Remove(onecowmill);
        }
       
    }
    public partial class MainWindow : Window
    {
        BitmapImage carBitmap = new BitmapImage(new Uri("pack://application:,,,/1200px-Morabaraba_board.svg.png"));
        Brush[] colourme = { Brushes.Yellow, Brushes.Blue, Brushes.Green };
        Brush[] colourpositions = { Brushes.Yellow, Brushes.Yellow, Brushes.Yellow, Brushes.Yellow, Brushes.Yellow, Brushes.Yellow, Brushes.Yellow, Brushes.Yellow, Brushes.Yellow, Brushes.Yellow, Brushes.Yellow, Brushes.Yellow, Brushes.Yellow, Brushes.Yellow, Brushes.Yellow, Brushes.Yellow, Brushes.Yellow, Brushes.Yellow, Brushes.Yellow, Brushes.Yellow, Brushes.Yellow, Brushes.Yellow, Brushes.Yellow, Brushes.Yellow };
        Players firstplayer = new Players("1", Brushes.Blue);
        Players secondplayer = new Players("2", Brushes.Green);
        public int PCbuttoncounter = 0;
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
            PCbuttoncounter++;
            int playerwhat = Convert.ToInt32(player.Text);
            string positionis = Convert.ToString(t1.Text);
            Gameboard gameinitalise = new Gameboard(colourpositions);
            Brush[] colourme = { Brushes.Yellow, Brushes.Blue, Brushes.Green };
            if (playerwhat == 1)
            {
                gameinitalise.placements(colourme[1], positionis);
                firstplayer.addplacementtoplayer(positionis);
                firstplayer.increasecows();
                player.Text = "2";
            }
            else if (playerwhat == 2)
            {
                gameinitalise.placements(colourme[2], positionis);
                secondplayer.addplacementtoplayer(positionis);
                secondplayer.increasecows();
                player.Text = "1";
            }
            else { MessageBox.Show("Only player 1 and 2 allowed"); }

            gameinitalise.updateboardvisual(positions1, playerwhat);
            t1.Text = "Pick a Position";

        }
    }
}
