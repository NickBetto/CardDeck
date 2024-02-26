using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace CardDeck
{
    public partial class Form1 : Form
    {
        List<string> deck = new List<string>();
        List<string> dealerCards = new List<string>();
        List<string> playerCards = new List<string>();
        

        public Form1()
        {
            InitializeComponent();
            
            deck.AddRange(new string[] { "2H", "3H", "4H", "5H", "6H", "7H", "8H", "9H", "10H", "JH", "QH", "KH", "AH" });
            deck.AddRange(new string[] { "2D", "3D", "4D", "5D", "6D", "7D", "8D", "9D", "10D", "JD", "QD", "KD", "AD" });
            deck.AddRange(new string[] { "2C", "3C", "4C", "5C", "6C", "7C", "8C", "9C", "10C", "JC", "QC", "KC", "AC" });
            deck.AddRange(new string[] { "2S", "3S", "4S", "5S", "6S", "7S", "8S", "9S", "10S", "JS", "QS", "KS", "AS" });

            ShowDeck();

        
        }

        public void ShowDeck()
        {
            outputLabel.Text = "";

            for(int i = 0; i < deck.Count(); i++)
            {
                outputLabel.Text += $"{deck[i]} ";
            }
        }

        private void shuffleButton_Click(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer(Properties.Resources.Shuffle1);
            sp.Play();
            List<string> deckTemp = new List<string>();
            Random randGen = new Random();
            shuffleButton.Enabled = false;
            dealButton.Enabled = true;
            shuffleButton.BackColor = Color.Gray;
            dealButton.BackColor = Color.White;

            while (deck.Count > 0)
            {
                int index = randGen.Next(0, deck.Count);                
                deckTemp.Add(deck[index]);
                deck.RemoveAt(index);
            }

            deck = deckTemp;
            ShowDeck();
        }

        private void dealButton_Click(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer(Properties.Resources.Deal);
            dealButton.Enabled = false;
            collectButton.Enabled = true;
            collectButton.BackColor = Color.White;
            dealButton.BackColor = Color.Gray;

            for (int i =0; i < 5; i++)
            {
                playerCards.Add(deck[0]);
                deck.RemoveAt(0);
                dealerCards.Add(deck[0]);
                deck.RemoveAt(0);
            }

            for (int i = 0; i < playerCards.Count(); i++)
            {
                playerCardsLabel.Text += $"{playerCards[i]} ";
                sp.Play();
                playerCardsLabel.Refresh();
                Thread.Sleep(500);

                dealerCardsLabel.Text += $"{dealerCards[i]} ";
                sp.Play();
                dealerCardsLabel.Refresh();
                Thread.Sleep(500);
            }
            ShowDeck();
        }

        private void collectButton_Click(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer(Properties.Resources.Collect);
            deck.AddRange(playerCards);
            deck.AddRange(dealerCards);
            playerCardsLabel.Text = "";
            dealerCardsLabel.Text = "";
            collectButton.Enabled = false;
            shuffleButton.Enabled = true;
            shuffleButton.BackColor = Color.White;
            collectButton.BackColor = Color.Gray;

            for (int i = 0; i < playerCards.Count(); i++)
            {
                deck.Add(playerCards[i]);
            }
            for (int i = 0; i < dealerCards.Count(); i++)
            {
                deck.Add(dealerCards[i]);
            }
            sp.Play();
            ShowDeck();
            playerCards.Clear();
            dealerCards.Clear();
        }
    }
}
