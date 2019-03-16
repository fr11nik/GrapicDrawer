using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicDraw
{
    class EquationRecognition
    {
        private string Equation;
        private bool PresenceOfErrors = false;


        public EquationRecognition(string equation)
        {
            Equation = equation;
            
            SyntaxCheck();

        }
        
        
        private void SyntaxCheck()
        {
            CheckOnForbiddenSymbols();
            ExtractRootStrings();
            CheckOnAllowedSymbols();
            StartConvert(); 
        }
        public void CheckOnForbiddenSymbols()
        {
            char[] arrayforbiddenSymbols = { ',', '.', '&', '#', '@', '!', '_', '=', '"', '№', ':', '%', '?', '~', '`' };
            //  -1 means elements will not be spotted and null check
            if (Equation.IndexOfAny(arrayforbiddenSymbols) != -1 || Equation.Length == 0)
            {
                PresenceOfErrors = true;
                return;
            }
            
        }
        private void ExtractRootStrings()
        {

            string pattern1 = @"sqrt[(](x?|[0-9]{0,})(x?|[0-9]{0,2}).+[)]$";
            Regex rg = new Regex(pattern1);
            Match mt = rg.Match(Equation);
            if (mt.Success)
            {
                string t = mt.Value;
                Equation = Equation.Replace(t, "");
                MessageBox.Show(Equation);
                EquationConvert eq = new EquationConvert("dont start");
                eq.MethodAdd(t);
            }
            ///////////////////             

        }
        private void CheckOnAllowedSymbols()
        {
            char[] arrayAllowedSymbols = new char[] { 'x', '-', '+', '*', '/', '^', '(', ')' };

            foreach (char value in Equation)
            {
                //if elements notDigit then check on allowed Symbols

                if (!char.IsDigit(value))
                {
                    //return -1 because its means that in equation will not be elemets from arrayAllowedSymbols
                    PresenceOfErrors = value.ToString().IndexOfAny(arrayAllowedSymbols) == -1 ? true : false;
                    if (PresenceOfErrors) return;

                }
            }
        }
        private void StartConvert()
        {
            if (!PresenceOfErrors)
            {
                Form1 form1 = new Form1(Equation);
                form1.ShowDialog();
            }
            else SendError();
        }
        public void SendError()
        {
            MainForm mainForm = new MainForm();
           
            mainForm.Error();
            mainForm.Update();

        }
       

    }
  
}

    

