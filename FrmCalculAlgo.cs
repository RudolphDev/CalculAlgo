using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculAlgo
{
	public partial class FrmCalculAlgo : Form
	{
		private Calcul _calcul;

		public FrmCalculAlgo()
		{
			InitializeComponent();
			_calcul = new Calcul();
		}

		#region Combinaison
		private void BtnCombCalc_Click(object sender, EventArgs e)
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

						TxtResultComb.Text = "Le résultat de " + inputK.ToString() + " parmi " + inputN.ToString() + " est " + resultat.ToString();
						TxtNValComb.Text = "";
						TxtKValComb.Text = "";
					}
					else
						TxtResultComb.Text = "La valeur de n doit être supérieur ou égal à la valeur de k";
				}
				else
					TxtResultComb.Text = "Erreur de saisie dans la valeur de k";
			}
			else
				TxtResultComb.Text = "Erreur de saisie dans la valeur de n";
		}
		#endregion

		#region arrangement
		private void BtnArrCalc_Click(object sender, EventArgs e)
		{
			int inputN;
			int inputK;
			if (int.TryParse(TxtNValArr.Text, out inputN))
			{
				if (int.TryParse(TxtKValArr.Text, out inputK))
				{
					if (inputN >= inputK)
					{
						int p = inputN - inputK;
						double factN, factP;
						factN = _calcul.Factoriel(inputN);
						factP = _calcul.Factoriel(inputK);

						double resultat = factN / factP;

						TxtResultArr.Text = "Le résultat de " + inputN.ToString() + " parmi " + inputK.ToString() + " est " + resultat.ToString();
						TxtNValArr.Text = "";
						TxtKValArr.Text = "";
					}
					else
						TxtResultArr.Text = "La valeur de n doit être supérieur ou égal à la valeur de k";
				}
				else
					TxtResultArr.Text = "Erreur de saisie dans la valeur de k";
			}
			else
				TxtResultArr.Text = "Erreur de saisie dans la valeur de n";
		}
		#endregion

		#region Binomiale
		private void BtnBinoCalc_Click(object sender, EventArgs e)
		{
			int inputN, inputK;
			double inputP, resultat;
			TxtResultBino.Text = "";

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
								if (RdBtnBinoEgal.Checked == true)
								{
									resultat = _calcul.Binomial(inputN, inputK, inputP);
									TxtResultBino.Text = "Le résultat de la loi binomale est " + resultat.ToString();
								}
								else if (RdBtnBinoInf.Checked == true)
									BinomialInf(inputN, inputK, inputP);

								else if (RdBtnBinoSup.Checked == true)
									BinomialSup(inputN, inputK, inputP);

								else if (RdBtnBinoInfEgal.Checked == true)
									BinomialInfEgal(inputN, inputK, inputP);

								else
									BinomialSupEgal(inputN, inputK, inputP);
							}
							else
								TxtResultBino.Text = "La valeur de k doit etre inférieur ou égal à n ";
						}
						else
							TxtResultBino.Text = "La valeur de la probabilité doit etre comprise entre O et 1";
					}
					else
						TxtResultBino.Text = "Erreur de saisie dans la valeur de p";
				}
				else
					TxtResultBino.Text = "Erreur de saisie dans la valeur de k";
			}
			else
				TxtResultBino.Text = "Erreur de saisie dans la valeur de n";
		}

		private void BinomialSupEgal(int inputN, int inputK, double inputP)
		{
			int a = inputK;
			double ResultComb;
			double resultat = 0;

			while (a <= inputN)
			{
				ResultComb = _calcul.Binomial(inputN, a, inputP);
				TxtResultBino.Text = TxtResultBino.Text + "Le résultat de la binomial avec k = " + a.ToString() + " est " + ResultComb.ToString() + "\n";
				resultat = resultat + ResultComb;
				a++;
			}
			TxtResultBino.Text = TxtResultBino.Text + "Le résultat final de X supérieur ou égal à " + inputK.ToString() + " est " + resultat.ToString();

		}

		private void BinomialInfEgal(int inputN, int inputK, double inputP)
		{
			int a = 0;
			double ResultComb;
			double resultat = 0;

			while (a <= inputK)
			{
				ResultComb = _calcul.Binomial(inputN, a, inputP);
				TxtResultBino.Text = TxtResultBino.Text + "Le résultat de la binomial avec k = " + a.ToString() + " est " + ResultComb.ToString() + "\n";
				resultat = resultat + ResultComb;
				a++;
			}
			TxtResultBino.Text = TxtResultBino.Text + "Le résultat final de X inférieur ou égal  à " + inputK.ToString() + " est " + resultat.ToString();

		}

		private void BinomialSup(int inputN, int inputK, double inputP)
		{
			int a = inputK++;
			double ResultComb;
			double resultat = 0;

			while (a <= inputN)
			{
				ResultComb = _calcul.Binomial(inputN, a, inputP);
				TxtResultBino.Text = TxtResultBino.Text + "Le résultat de la binomial avec k = " + a.ToString() + " est " + ResultComb.ToString() + "\n";
				resultat = resultat + ResultComb;
				a++;
			}
			TxtResultBino.Text = TxtResultBino.Text + "Le résultat final de X supérieur à " + inputK.ToString() + " est " + resultat.ToString();

		}

		private void BinomialInf(int valN, int valK, double probEvent)
		{
			int i = 0;
			double resultBino;
			double resultat = 0;

			while (i < valK)
			{
				resultBino = _calcul.Binomial(valN, i, probEvent);
				TxtResultBino.Text = TxtResultBino.Text + "Le résultat de la binomial avec k = " + i.ToString() + " est " + resultBino.ToString() + "\n";
				resultat = resultat + resultBino;
				i++;
			}
			TxtResultBino.Text = TxtResultBino.Text + "Le résultat final de X inférieur à " + valK.ToString() + " est " + resultat.ToString();
			TxtResultBino.Focus();
			TxtResultBino.Select(TxtResultBino.Text.Length, 0);

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
			TxtResultPoiss.Text = "";

			if (double.TryParse(TxtPoissonLambdaVal.Text, out inputLambda))
			{
				if (int.TryParse(TxtPoissonKVal.Text, out inputK))
				{
					if (RdBtnPoissEgal.Checked == true)
					{
						resultat = _calcul.Poisson(inputK, inputLambda);
						TxtResultPoiss.Text = " La résultat de la loi de Poisson est " + resultat.ToString();
					}
					else if (RdBtnPoissInf.Checked == true)
						PoissonInf(inputK, inputLambda);

					else
						PoissonInfEgal(inputK, inputLambda);


				}
				else
					TxtResultPoiss.Text = "Erreur de saisie dans la valeur de k";
			}
			else
				TxtResultPoiss.Text = "Erreur de saisie dans la valeur de \u03BB";
		}

		private void PoissonInfEgal(int inputK, double inputLambda)
		{
			int a = 0;
			double resultPoiss;
			double resultat = 0;
			while (a <= inputK)
			{
				resultPoiss = _calcul.Poisson(a, inputLambda);
				TxtResultPoiss.Text = TxtResultPoiss.Text + "Le résultat de la loi de Poisson pour k = " + a.ToString() + " est " + resultPoiss.ToString();
				resultat = resultat + resultPoiss;
				a++;
			}
			TxtResultPoiss.Text = TxtResultPoiss.Text + "Le résultat final de la loi de poisson est " + resultat.ToString();
		}

	private void PoissonInf(int inputK, double inputLambda)
	{
		int a = 0;
		double resultPoiss;
		double resultat = 0;
		while (a < inputK)
		{
			resultPoiss = _calcul.Poisson(a, inputLambda);
			TxtResultPoiss.Text = TxtResultPoiss.Text + "Le résultat de la loi de Poisson pour k = " + a.ToString() + " est " + resultPoiss.ToString();
			resultat = resultat + resultPoiss;
			a++;
		}
		TxtResultPoiss.Text = TxtResultPoiss.Text + "Le résultat final de la loi de poisson est " + resultat.ToString();
	}

	private void BtnPoissonClear_Click(object sender, EventArgs e)
	{
		TxtPoissonKVal.Text = "";
		TxtPoissonLambdaVal.Text = "";
	}
	#endregion


}


}


