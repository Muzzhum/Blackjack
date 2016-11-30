using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kortspill
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		Random rng = new Random();

		Bitmap[] suitArray = { Properties.Resources.spar, Properties.Resources.hjerter,
							Properties.Resources.kløver, Properties.Resources.ruter};

		List<Card> playerCards = new List<Card>();
		List<Card> dealerCards = new List<Card>();

		int cardsDrawn = 0;
		bool[,] isCardDrawn = new bool[4, 13];

		public class Card
		{
			public Point startPoint;
			public PictureBox suit;
			public Label valuelabel;

			public Card(int x, int y, Bitmap image, string value)
			{
				startPoint = new Point(x, y);

				suit = new PictureBox();
				suit.Location = startPoint;
				suit.Width = 40;
				suit.Height = 40;
				suit.Image = image;

				valuelabel = new Label();
				valuelabel.Location = new Point(x + 40, y);
				valuelabel.Size = 
				valuelabel.Text = value;
			}

		};

		private void cardHit()
		{
			int suit = rng.Next(0, suitArray.Length);
			int value = rng.Next(0, 13);

			if (!isCardDrawn[suit, value])
			{
				suit1PB.BackgroundImage = suitArray[suit];

				switch (value)
				{
					case 0:
						value1Lbl.Text = "A";
						break;
					case 10:
						value1Lbl.Text = "J";
						break;
					case 11:
						value1Lbl.Text = "Q";
						break;
					case 12:
						value1Lbl.Text = "K";
						break;
					default:
						value1Lbl.Text = (value + 1).ToString();
						break;
				}
				isCardDrawn[suit, value] = true;
			}
			else
				cardHit();
		}

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

		private void startBtn_Click(object sender, EventArgs e)
		{
			Player1GB.Visible = true;
			DealerGB.Visible = true;

			for (int i = 0; i < 2; i++)
			{
				playerCards.Add(new Card());
				playerCards[i].startPoint = new Point()
			}
		}
	}
}
