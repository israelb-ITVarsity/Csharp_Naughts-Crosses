using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Reflection;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        bool playerTurn = true;// X Turn -> true , O Turn -> false
        int turnCount = 0;
        int winStreak = 0; // Positive for X, Negative for O
        string playerNameX = "";
        string playerNameO = "";

        
        public Form1()
        {
            Home startPage = new Home();
            startPage.ShowDialog();
            InitializeComponent();
            updateWinStreak("");
            // Load existing winners from the text file
            DisplayWinner();
           
        }

        private void buttonClick(object sender, EventArgs e)
        {
            Button theButtton = (Button)sender;

            if (playerTurn)
            {
                theButtton.Text = "X";
                theButtton.Enabled = false;
            }
            else
            {
                theButtton.Text = "O";
                theButtton.Enabled = false;
            }

            turnCount++;//for the draws, the maxium play is 9
            playerTurn = !playerTurn;
            checkWinner();
        }

        private void checkWinner()
        {
            /*
            foreach(Control x in Controls)//emunmeration of all controls{}
            */
            bool weHaveWinner = false;

            //Switch possible ?

            //---
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A2.Enabled))
                weHaveWinner = true;
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B2.Enabled))
                weHaveWinner = true;
            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C2.Enabled))
                weHaveWinner = true;

            // |||
            else if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!B1.Enabled))
                weHaveWinner = true;
            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!B2.Enabled))
                weHaveWinner = true;
            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!B3.Enabled))
                weHaveWinner = true;

            //X
            else if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!B2.Enabled))
                weHaveWinner = true;
            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!B2.Enabled))
                weHaveWinner = true;

            


            if (weHaveWinner)
            {
                //disableAllbtn();

                String winner = "";

                if (playerTurn)
                    winner = PlayerO.Text;
                else
                    winner = PlayerX.Text;
                updateWinStreak(winner);
                LoadWinner(winner);

                MessageBox.Show(winner + " Wins!", "GG");
                autoNewGame();
                DisplayWinner();

            }
            else
            {
                if(turnCount == 9)
                {
                    MessageBox.Show("Draw");
            
                    //disableAllbtn();
                    autoNewGame();
                }

            }

        }

        /*
        private void disableAllbtn()
        {
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }
            }
            catch { }//Ignoring the menu strip (is not a button)
        }*/

        private void autoNewGame()
        {
            playerTurn = true;
            turnCount = 0;

            try
            {
                foreach (Control c in Controls)
                {
                    // This check is important. You can not rely on the exception handling to only process buttons.
                    // If another type of control is encountered, the exception handling will cause this code to exit
                    // without necessarily clearing all the buttons.
                    if (c is Button)
                    {
                        (c as Button).Enabled = true;
                        (c as Button).Text = "";
                    }
                }
            }
            catch { }
        } 

        /// <summary>
        /// Updates the label indicating the current win streak
        /// </summary>
        /// <param name="winner">Can take "X" or "O" or any other value to reset</param>
        private void updateWinStreak(string winner)
        {
            if (winner == "X")
            {
                if (winStreak < 0) // If O was on a win streak, zero it before incrementing
                    winStreak = 0;
                winStreak++;
            }
            else if (winner == "O")
            {
                if (winStreak > 0) // If X was on a win streak, zero it before decrementing
                    winStreak = 0;
                winStreak--;
            }
            else
            {
                winStreak = 0;
            }

            winStreakLabel.Visible = (winStreak != 0);
            winStreakLabel.Text = String.Format("{0} is on a win streak of {1}", winner, Math.Abs(winStreak));
        }

        private void winStreakLabel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to reset the win streak?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                updateWinStreak("");
            }
        }

        private void InputPlayerX_TextChanged(object sender, EventArgs e)
        {

        }

        private void InputPLayerO_TextChanged(object sender, EventArgs e)
        {

        }

        private void PlayerX_Click(object sender, EventArgs e)
        {

        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            //Get the names added in the textbox
            playerNameX = InputPlayerX.Text;
            playerNameO = InputPlayerO.Text;

            //assign the names in the labels
            PlayerX.Text = $"{playerNameX} - X";
            PlayerO.Text = $"{playerNameO} - O";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=Israel-Lenovo;Initial Catalog=TickTackToe;Integrated Security=True";
           SqlConnection connection = new SqlConnection(connectionString);
           
            connection.Open();

            string query = "DELETE FROM Winner;";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.ExecuteNonQuery();  
            }


                // Clear the ListBox
                listBox.Items.Clear();
            MessageBox.Show("Scoreboard has been cleared.");

            connection.Close();

            
        }

        public void LoadWinner(string name)
        {
            //specify address of server and database
            string scoreboardFilePath = "Data Source=Israel-Lenovo;Initial Catalog=TickTackToe;Integrated Security=True";
            //Establish connection
            using (SqlConnection sqlCon = new SqlConnection(scoreboardFilePath))
            {
                //Open connection
                sqlCon.Open();

                string query = "INSERT INTO Winner (Firstname) VALUES('" + name + "');";

                //executing the query
                using (SqlCommand cmd = new SqlCommand(query, sqlCon))
                {
                    // Use parameters to prevent SQL injection
                    cmd.Parameters.AddWithValue("Firstname", name);   
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Person has been saved to database table!");
                sqlCon.Close();
            }

        }

        private void DisplayWinner()
        {
            string connectionString = "Data Source=Israel-Lenovo;Initial Catalog=TickTackToe;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "SELECT Firstname FROM Winner;"; 

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    listBox.Items.Clear(); // Clear the ListBox first

                    while (reader.Read())
                    {
                        string name = reader["Firstname"].ToString();
                        listBox.Items.Add(name);// Add the names to the ListBox
                    }
                }
                connection.Close();
            }

        }

    }
}
