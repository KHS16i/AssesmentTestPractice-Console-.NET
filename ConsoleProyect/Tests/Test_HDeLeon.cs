using System.Text.RegularExpressions;


namespace ConsoleProyect.Tests
{
    public class Test_HDeLeon
    {
        #region REVERSA CADENA DE CARACTERES

        public string txtReverted(string txt)
        {
            char[] chars = txt.ToCharArray();
            string txtR = "";

            for (int i = chars.Length - 1; i >= 0; i--)
            {
                txtR = txtR + chars[i];
            }
            return txtR;
        }

        #endregion

        #region CUENTA CARACTERES

        public int charCount(string txt, char crt)
        {
            int n = 0;
            //Forma imperativa
            foreach (var item in txt)
            {
                if (item == crt)
                {
                    n++;
                }
            }

            //Forma declarativa
            //n = txt.Where(x => x == crt).Count();

            return n;
        }

        #endregion

        #region DISTANCIA DE HAMMING

        public int hammingDistance(string txt1, string txt2)
        {
            int n = 0;

            if (txt1.Length != txt2.Length)
            {
                Console.WriteLine("Los textos deben de medir lo mismo");
            }
            else
            {
                for (int i = 0; i < txt1.Length; i++)
                {
                    if (txt1[i] != txt2[i])
                    {
                        n++;
                    }
                }
            }

            return n;
        }

        #endregion

        #region CONTADOR DE PALABRAS

        public int wordsCounter(string txt)
        {
            int n = 1;

            //Convierte el texto si este tiene más de un espacio agregado.
            txt = Regex.Replace(txt, @"\s+", " ").Trim();

            foreach (var item in txt)
            {
                if (item.ToString() == " ")
                {
                    n++;
                }
            }

            //Otra solucion usando Split
            //var words = txt.Split(' ');
            //n = words.Length;

            return n;
        }

        #endregion

        #region CONTADOR DE NUMEROS EN TEXTO

        public int lettersCount(string txt)
        {
            char[] chars = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
            int n = 0;

            for (int i = 0; i < txt.Length; i++)
            {
                for (int j = 0; j < chars.Length; j++)
                {
                    if (txt[i] == chars[j])
                    {
                        n++;
                    }
                }
            }

            //Otra solucion              //Para contar letras.
            //string pattern = @"[0-9]" //string pattern = @"[a-zA-Z]";
            //var regex = new Regex(pattern);
            //n = regex.Matches(txt).Count();


            return n;
        }

        #endregion

        #region CUENTA REPETIDOS

        public List<string> repeatCount(int[] num)
        {
            int aux = 0;
            int n = 0;

            List<string> res = new List<string>();

            for (int i = 0; i < num.Length; i++)
            {
                for (int j = 0; j < num.Length; j++)
                {
                    aux = num[i];
                    if (aux == num[j])
                    {
                        n++;
                    }
                }
                if (num[i] != aux)
                {
                    res.Add("El numero "  + num[i].ToString() + " se repite " + n.ToString() + " veces.");
                }
                n = 0;
            }
            if (res.Count() == 0)
            {
                res.Add("Ningun numero se repite.");
            }

            return res;
        }

        #endregion
    }
}
