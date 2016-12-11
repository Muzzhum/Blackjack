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

namespace Kortspill
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		
		Random rng = new Random();

		string[] fileArray = Directory.GetFiles(@"..\..\Resources\cards");
		Image[,] picArray = new Image[4, 13];

		List<Card> playerHand = new List<Card>();
		List<Card> dealerHand = new List<Card>();
		int playerSum, dealerSum;

		bool[,,] isCardDrawn = new bool[1, 4, 13];

		private void Form1_Load(object sender, EventArgs e)
		{
			int count = 0;

			// this sets all images into picArray

			for (int i = 0; i < picArray.GetLength(0); i++)
			{
				for (int j = 0; j < picArray.GetLength(1); j++)
				{
					picArray[i, j] = Image.FromFile(fileArray[count], false);
					count++;
				}
			}
		}

		private void startBtn_Click(object sender, EventArgs e)
		{
			Player1GB.Visible = true;
			DealerGB.Visible = true;
            HolePB.Visible = true;

			for (int i = 0; i < 2; i++)
			{
				cardHit(playerHand, Player1GB);
				playerSum += playerHand.Last().value;

				cardHit(dealerHand, DealerGB);
				dealerSum += dealerHand.Last().value;
			}

			hand0SumLbl.Text = playerSum.ToString();


			startBtn.Visible = false;

			if (playerSum == 21)
			{
				MessageBox.Show("Du har fått en blackjack! Gratulerer!", "Gratulerer!", MessageBoxButtons.OK);
			}
		}

		private void hitBtn_Click(object sender, EventArgs e)
		{
			cardHit(playerHand, Player1GB);

			playerSum = 0;
			foreach (Card card in playerHand)
				playerSum += card.value;

			aceCorrector(playerSum, playerHand);
			

			hand0SumLbl.Text = playerSum.ToString();


			if (playerSum > 21)
			{
				// Game is lost, gimme a message and stuff
				MessageBox.Show("Du har gått bust, vil du starte på nytt?", "Du har tapt!");
				reset();
				hand0SumLbl.Text = "0";
			}
		}

		private void standBtn_Click(object sender, EventArgs e)
		{
			hitBtn.Enabled = false;
			HolePB.Visible = false;
			dealersTurn();
			winChecker();
		}

		private void surrenderBtn_Click(object sender, EventArgs e)
		{
			reset();
		}

		private void dealersTurn()
		{
			while (dealerSum <= 16)
			{
				cardHit(dealerHand, DealerGB);
				dealerSum += dealerHand.Last().value;
				aceCorrector(dealerSum, dealerHand);
			}

			DealerSumLbl.Text = dealerSum.ToString();
		}

		// Draws a new card and fixes everything around it.
		private void cardHit(List<Card> hand, GroupBox groupBox)
		{
			int suit = rng.Next(0, picArray.GetLength(0));
			int value = rng.Next(0, picArray.GetLength(1));

			bool actuallyDrew = false;

			// the loop is here in case isCardDrawn has more than one 0th dimension, i.e. more than one deck. 
			for (int i = 0; i < isCardDrawn.GetLength(0); i++)
			{
				if (!isCardDrawn[i, suit, value])
				{	
					/* trueValue is used to make the cards hold their own value. 
					 * 
					 * aces are initially 11, can be 1 but that's changed elsewhere
					 * 2-10 are values 2-10, respectively
					 * face cards are 10
					 */
					int trueValue = 0;
					if (value == 0)
						trueValue = 11;
					else if (value > 0 && value < 10)
						trueValue = value + 1;
					else if (value >= 10)
						trueValue = 10;

					hand.Add(new Card(7 + hand.Count() * 75, 20, picArray[suit, value], trueValue));
					groupBox.Controls.Add(hand.Last().cardPB);
					isCardDrawn[i, suit, value] = true;
					actuallyDrew = true;

					if (value == 0)
						hand.Last().isAce = true;

					break;
				}
			}

			if (!actuallyDrew)
				cardHit(hand, groupBox);
		}

		// If the hand is over 21 and there are aces in it, this corrects that. 
		private void aceCorrector(int workingNum, List<Card> hand)
		{
			if (workingNum > 21)
			{
				foreach (Card card in hand)
				{
					if (card.isAce && !card.aceAccounted)
					{
						card.value = 1;
						card.aceAccounted = true;
						workingNum -= 10;

						if (workingNum <= 21)
							break;
					}
				}
			}
		}


		private void winChecker()
		{
			if (playerSum <= dealerSum && dealerSum <= 21)
			{
				MessageBox.Show("Du har tapt, dealer hadde flere poeng enn deg. Vil du spille igjen?",
								"Du har tapt!", MessageBoxButtons.OK);
				reset();
			}
			else
			{
				MessageBox.Show("Du vant! Gratulerer. Vil du spille igjen?",
								"Gratulerer!", MessageBoxButtons.OK);
				reset();
			}
		}

		private void reset()
		{
			// Reset all player attributes
			foreach (Card card in playerHand)
				Player1GB.Controls.Remove(card.cardPB);
			playerHand.Clear();
			playerHand.TrimExcess();
			playerSum = 0;

			// Reset all dealer attributes
            foreach (Card card in dealerHand)
                DealerGB.Controls.Remove(card.cardPB);
            dealerHand.Clear();
            dealerHand.TrimExcess();
            dealerSum = 0;

			// Doing this because I'm too lazy to make it fix everything on its own
			// Instead just use already working assets
			startBtn.Text = "Restart";
			startBtn.Visible = true;

            HolePB.Visible = false;
			hitBtn.Enabled = true;
		}
	}

	class Card
	{
		public PictureBox cardPB;

		public bool isAce = false;
		public bool aceAccounted = false;

		public int value;

		public Card(int x, int y, Image image, int num)
		{
			cardPB = new PictureBox();
			cardPB.Location = new Point(x, y);
			cardPB.Width = 75;
			cardPB.Height = 109;
			cardPB.BackgroundImage = image;
			cardPB.BackgroundImageLayout = ImageLayout.Zoom;
			cardPB.Visible = true;

			value = num;
		}
	};
}
