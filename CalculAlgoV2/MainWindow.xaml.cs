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

namespace CalculAlgo_V2
{
	/// <summary>
	/// Logique d'interaction pour MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{

		public Calcul _calcul = new Calcul();

		public MainWindow()
		{
			InitializeComponent();
		}


		#region Arrangement 
		private void BtnArr_Click(object sender, RoutedEventArgs e)
		{
			int inputN, inputK, p;
			double factN, factP, resultat;

			if (int.TryParse(TxtNValArr.Text, out inputN))
			{
				if (int.TryParse(TxtKValArr.Text, out inputK))
				{
					if (inputK <= inputN)
					{
						p = inputN - inputK;
						factN = _calcul.Factorielle(inputN);
						factP = _calcul.Factorielle(p);
						resultat = factN / factP;
						TxtArrResult.Text = "Le résultat de l'arrangement est " + resultat.ToString();
					}
					else
						TxtArrResult.Text = "La valeur de k doit être inférieur ou égal à n";
				}
				else
					TxtArrResult.Text = "Erreur de saisie dans la valeur de k";
			}
			else
				TxtArrResult.Text = "Erreur de saisie dans la valeur de n";
		}

		private void BtnArrClear_Click(object sender, RoutedEventArgs e)
		{
			TxtKValArr.Text = "";
			TxtNValArr.Text = "";
		}
		#endregion

		#region Combinaison
		private void BtnCombCalc_Click(object sender, RoutedEventArgs e)
		{

			int inputN;
			int inputK;
			if (int.TryParse(TxtNValComb.Text, out inputN))
			{
				if (int.TryParse(TxtKValComb.Text, out inputK))
				{
					double resultat;

					if (inputN >= inputK)
					{
						resultat = _calcul.Combinaison(inputN, inputK);

						TxtCombResult.Text = "Le résultat de " + inputK.ToString() + " parmi " + inputN.ToString() + " est " + resultat.ToString();
					}
					else
						TxtCombResult.Text = "La valeur de n doit être supérieur ou égal à la valeur de k";
				}
				else
					TxtCombResult.Text = "Erreur de saisie dans la valeur de k";
			}
			else
				TxtCombResult.Text = "Erreur de saisie dans la valeur de n";
		}

		private void BtnCombClear_Click(object sender, RoutedEventArgs e)
		{
			TxtNValComb.Text = "";
			TxtKValComb.Text = "";
		}
		#endregion

		#region Binomiale
		private void BtnBinoCalc_Click(object sender, EventArgs e)
		{
			int inputN, inputK;
			double inputP, resultat;
			TxtBinoResult.Document.Blocks.Clear();

			TxtPValBino.Text = TxtPValBino.Text.Replace('.', ',');
			if (int.TryParse(TxtNValBino.Text, out inputN))
			{
				if (int.TryParse(TxtKValBino.Text, out inputK))
				{
					if (double.TryParse(TxtPValBino.Text, out inputP))
					{
						if (inputP <= 1 && inputP >= 0)
						{
							if (inputN >= inputK)
							{

								if (RdBtnBinoEgal.IsChecked == true)
								{
									resultat = _calcul.Binomial(inputN, inputK, inputP);
									TxtBinoResult.AppendText("Le résultat de la loi binomale est " + resultat.ToString());
								}
								else if (RdBtnBinoInf.IsChecked == true)
									BinomialInf(inputN, inputK, inputP);

								else if (RdBtnBinoSup.IsChecked == true)
									BinomialSup(inputN, inputK, inputP);

								else if (RdBtnBinoInfEgal.IsChecked == true)
									BinomialInfEgal(inputN, inputK, inputP);

								else
									BinomialSupEgal(inputN, inputK, inputP);
							}
							else
								TxtBinoResult.AppendText("La valeur de k doit etre inférieur ou égal à n ");
						}
						else
							TxtBinoResult.AppendText("La valeur de la probabilité doit etre comprise entre O et 1");
					}
					else
						TxtBinoResult.AppendText("Erreur de saisie dans la valeur de p");
				}
				else
					TxtBinoResult.AppendText("Erreur de saisie dans la valeur de k");
			}
			else
				TxtBinoResult.AppendText("Erreur de saisie dans la valeur de n");
		}

		private void BinomialSupEgal(int inputN, int inputK, double inputP)
		{
			int a = inputK;
			double ResultComb;
			double resultat = 0;

			while (a <= inputN)
			{
				ResultComb = _calcul.Binomial(inputN, a, inputP);
				TxtBinoResult.AppendText("Le résultat de la binomial avec k = " + a.ToString() + " est " + ResultComb.ToString() + "\r");
				resultat = resultat + ResultComb;
				a++;
			}
			TxtBinoResult.AppendText( "Le résultat final de X supérieur ou égal à " + inputK.ToString() + " est " + resultat.ToString());

		}

		private void BinomialInfEgal(int inputN, int inputK, double inputP)
		{
			int a = 0;
			double ResultComb;
			double resultat = 0;

			while (a <= inputK)
			{
				ResultComb = _calcul.Binomial(inputN, a, inputP);
				TxtBinoResult.AppendText( "Le résultat de la binomial avec k = " + a.ToString() + " est " + ResultComb.ToString() + "\r");
				resultat = resultat + ResultComb;
				a++;
			}
			TxtBinoResult.AppendText( "Le résultat final de X inférieur ou égal  à " + inputK.ToString() + " est " + resultat.ToString());

		}

		private void BinomialSup(int inputN, int inputK, double inputP)
		{
			int a = inputK++;
			double ResultComb;
			double resultat = 0;

			while (a <= inputN)
			{
				ResultComb = _calcul.Binomial(inputN, a, inputP);
				TxtBinoResult.AppendText( "Le résultat de la binomial avec k = " + a.ToString() + " est " + ResultComb.ToString() + "\r");
				resultat = resultat + ResultComb;
				a++;
			}
			TxtBinoResult.AppendText( "Le résultat final de X supérieur à " + inputK.ToString() + " est " + resultat.ToString());

		}

		private void BinomialInf(int valN, int valK, double probEvent)
		{
			int i = 0;
			double resultBino;
			double resultat = 0;

			while (i < valK)
			{
				resultBino = _calcul.Binomial(valN, i, probEvent);
				TxtBinoResult.AppendText( "Le résultat de la binomial avec k = " + i.ToString() + " est " + resultBino.ToString() + " \r" );
				resultat = resultat + resultBino;
				i++;
			}
			TxtBinoResult.AppendText( "Le résultat final de X inférieur à " + valK.ToString() + " est " + resultat.ToString());

		}

		private void BtnBinoClear_Click(object sender, EventArgs e)
		{
			TxtKValBino.Text = "";
			TxtNValBino.Text = "";
			TxtPValBino.Text = "";
		}
		#endregion

		#region Poisson
		private void BtnPoissonCalc_Click(object sender, EventArgs e)
		{
			double inputLambda, resultat;
			int inputK;
			TxtPoissResult.Document.Blocks.Clear();

			if (double.TryParse(TxtLambdaValPoiss.Text, out inputLambda))
			{
				if (int.TryParse(TxtKValPoiss.Text, out inputK))
				{
					if (RdBtnPoissEgal.IsChecked == true)
					{
						resultat = _calcul.Poisson(inputK, inputLambda);
						TxtPoissResult.AppendText(" La résultat de la loi de Poisson est " + resultat.ToString());
					}
					else if (RdBtnPoissInf.IsChecked == true)
						PoissonInf(inputK, inputLambda);
					else
						PoissonInfEgal(inputK, inputLambda);
				}
				else
					TxtPoissResult.AppendText("Erreur de saisie dans la valeur de k");
			}
			else
				TxtPoissResult.AppendText("Erreur de saisie dans la valeur de \u03BB");
		}

		private void PoissonInfEgal(int inputK, double inputLambda)
		{
			int a = 0;
			double resultPoiss;
			double resultat = 0;
			while (a <= inputK)
			{
				resultPoiss = _calcul.Poisson(a, inputLambda);
				TxtPoissResult.AppendText(TxtPoissResult + "Le résultat de la loi de Poisson pour k = " + a.ToString() + " est " + resultPoiss.ToString()+"\r");
				resultat = resultat + resultPoiss;
				a++;
			}
			TxtPoissResult.AppendText(TxtPoissResult + "Le résultat final de la loi de poisson est " + resultat.ToString());
		}

		private void PoissonInf(int inputK, double inputLambda)
		{
			int a = 0;
			double resultPoiss;
			double resultat = 0;
			while (a < inputK)
			{
				resultPoiss = _calcul.Poisson(a, inputLambda);
				TxtPoissResult.AppendText( TxtPoissResult + "Le résultat de la loi de Poisson pour k = " + a.ToString() + " est " + resultPoiss.ToString()+"\r");
				resultat = resultat + resultPoiss;
				a++;
			}
			TxtPoissResult.AppendText( TxtPoissResult + "Le résultat final de la loi de poisson est " + resultat.ToString());
		}

		private void BtnPoissonClear_Click(object sender, EventArgs e)
		{
			TxtKValPoiss.Text = "";
			TxtLambdaValPoiss.Text = "";
		}
		#endregion


	}
}
