using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace LogoKaresz
{
	public partial class Form1 : Form
	{
		/* Függvények */
		void Bevezető_fa(int év,double meret)
        {
            if (év==1)
            {
				Előre(meret);
				Jobbra(180);
				Előre(meret);
				Jobbra(180);
            }
            else
            {
				Előre(meret);
				Balra(60);
				Bevezető_fa(év - 1, meret * 0.5);
				Jobbra(120);
				Bevezető_fa(év - 1, meret * 0.5);


				Jobbra(120);


				Előre(meret);
				Balra(180);

            }
        }

		/* Függvények vége */
		void FELADAT()
		{
			/* Ezt indítja a START gomb! */
			Bevezető_fa(5, 100);
			// Teleport(közép.X, közép.Y+150, észak);
		}
	}
}
