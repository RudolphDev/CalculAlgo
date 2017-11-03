using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculAlgo
{
	public class Calcul
	{

		public Calcul()
		{
		
		}

		public double Combinaison(int inputN, int inputK)
		{
			int p = inputN - inputK;
			double factN, factK, factP, resultat;

			factN = Factoriel(inputN);
			factK = Factoriel(inputK);
			factP = Factoriel(p);

			double a = factP * factK;
			resultat = factN / a;
			return (resultat);
		}

		public void FactorielProc(int n, out double result)
		{
			result = 1;
			while (n > 1)
			{
				result = n * result;
				n--;
			}
		}

		public double Factoriel(int n)
		{
			double result = 1;
			while (n > 1)
			{
				result = n * result;
				n--;
			}
			return (result);
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
			b = Factoriel(inputK);
			c = Math.Exp(moinsLambda);
			resultat = (a / b) * c;
			return (resultat);
		}
	}
}
