﻿using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Malkima
{
	internal class Fontes
	{
		private static PrivateFontCollection fontes = new PrivateFontCollection();

		static Fontes ()
		{
			CarregarFontes();
		}

		public static Font AplicarFontes (int tam = 11)
		{
			return new Font(fontes.Families[0], tam);
		}

		public static void CarregarFontes ()
		{
			string[] fontes_c =
			{
				@"fontes/acephimere.otf",
			};

			foreach(string f in fontes_c)
			{
				fontes.AddFontFile(f);
			}
		}
	}
}
