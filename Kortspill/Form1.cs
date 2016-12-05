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

		string[] fileArray = Directory.GetFiles(@"..\..\Resources");
		Image[,] picArray = new Image[4, 13];

		List<Card> playerHand = new List<Card>();
		List<Card> dealerCards = new List<Card>();
		int cardSum = 0;

		bool[,,] isCardDrawn = new bool[1, 4, 13];

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

		private void Form1_Load(object sender, EventArgs e)
		{
			int count = 0;
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

			for (int i = 0; i < 2; i++)
			{
				cardHit();
			}
		
			startBtn.Visible = false;
		}

		private void hitBtn_Click(object sender, EventArgs e)
		{
			if (cardSum < 21)
				cardHit();
			else
			{
				foreach (Card element in playerHand)
					if (element.isAce && element.aceAccounted)
					{
						DialogResult result = MessageBox.Show("Du har tapt, vil du spille igjen?", "Du tapte!", MessageBoxButtons.YesNo);

						if (result == DialogResult.Yes)
						{
							// TODO: make restart option
						}
						else
						{
							DealerGB.Visible = false;
							Player1GB.Visible = false;

						}
					}
			}
		}

		
		private void cardHit()
		{
			int suit = rng.Next(0, picArray.GetLength(0));
			int value = rng.Next(0, picArray.GetLength(1));

			foreach (Card element in playerHand)
			{
				if (element.isAce)
				{

				}
			}

			bool actuallyDrew = false;
			for (int i = 0; i < isCardDrawn.GetLength(0); i++)
			{
				if (!isCardDrawn[i, suit, value])
				{
					int trueValue = 0;
					if (value == 0)
						trueValue = 11;
					else if (value > 0 && value < 10)
						trueValue = value + 1;
					else if (value >= 10)
						trueValue = 10;
					playerHand.Add(new Card(7 + playerHand.Count() * 75, 20, picArray[suit, value], trueValue));
					Player1GB.Controls.Add(playerHand.Last().cardPB);
					isCardDrawn[i, suit, value] = true;
					actuallyDrew = true;

					if (value == 0)
						playerHand.Last().isAce = true;
					break;
				}
			}

			if (!actuallyDrew)
				cardHit();

			if (playerHand.Last().isAce)
			{
				if (cardSum + 11 <= 21)
				{
					cardSum += value + 1;
					hand0SumLbl.Text = cardSum.ToString();
				} else if (cardSum + 11 < 21 )
				{
					cardSum += 11;
				}
			} else if ( )
		}



		/*
		private void hitBtn_Click(object sender, EventArgs e)
		{ 
			if (cardsDrawn < 52)
			{
				cardHit();
				cardsDrawn++;
				cardCounterLbl.Text = cardsDrawn.ToString();
			}
			else
			{
				DialogResult reshuffle = MessageBox.Show("Du har trukket alle kortene, vil du stokke på nytt?", 
													"Det er ikke flere kort igjen!", MessageBoxButtons.YesNo);
				if (reshuffle == DialogResult.Yes)
				{
					cardsDrawn = 0;
					cardCounterLbl.Text = cardsDrawn.ToString();
					suit1PB.BackgroundImage = null;
					value1Lbl.Text = "";

					for (int i = 0; i < 4; i++)
						for (int j = 0; j < 13; j++)
							isCardDrawn[i, j] = false;
				}
				else
				{
					suit1PB.BackgroundImage = null;
					value1Lbl.Text = "";
				}
			}
		}
		*/

	}
}
