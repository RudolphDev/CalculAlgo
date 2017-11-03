using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculAlgo_V2
{
	public class Calcul
	{
		public double Factorielle(int nVal)
		{
			double result = 1;
			while (nVal > 1)
			{
				result = nVal * result;
				nVal--;
			}
			return (result);
		}

		public double Combinaison(int inputN, int inputK)
		{
			int p = inputN - inputK;
			double factN, factK, factP, resultat;

			factN = Factorielle(inputN);
			factK = Factorielle(inputK);
			factP = Factorielle(p);

			double a = factP * factK;
			resultat = factN / a;
			return (resultat);
		}
		public double Binomial(int inputN, int inputK, double inputP)
		{
			double resultComb, resultat;

			double t = 1 - inputP;
			int s = inputN - inputK;
			resultComb = Combinaison(inputN, inputK);
			double c = Math.Pow(inputP, inputK);
			double d = Math.Pow(t, s);
			resultat = resultComb * c * d;
			return (resultat);
		}

		public double Poisson(int inputK, double inputLambda)
		{
			double a, b, c, resultat;
			double moinsLambda = -inputLambda;
			a = Math.Pow(inputK, inputLambda);
			b = Factorielle(inputK);
			c = Math.Exp(moinsLambda);
			resultat = (a / b) * c;
			return (resultat);
		}
	}
}
