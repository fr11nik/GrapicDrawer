using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicDraw
{
    class EquationConvert
    {
        private string Equation;
        
        public EquationConvert(string equation)
        {
            if (equation != "dont start")
            {
                Equation = equation;

                DivisionFuncion();
            }
            else arrayEquationConvert = new List<string>();
        }
        private void RemoveingUnnecessary()
        {
             Equation.ToList().RemoveAll(element => element == '(' || element == ')');         
        }
        List<string> arrayEquationConvert;
        private void ExtractRootStrings()
        {

            //string pattern1 = @"sqrt[(](x?|[0-9]{0,})(x?|[0-9]{0,2}).+[)]$";
            //Regex rg = new Regex(pattern1);
            //Match mt = rg.Match(Equation);
            //if (mt.Success)
            //{
            //    string t = mt.Value;
            //    Equation = Equation.Replace(t, "");
            //    MessageBox.Show(Equation);
            //    EquationConvert eq = new EquationConvert("dont start");
            //    eq.MethodAdd(t);
            //}
            /////////////////             

        }
        private void DivisionOnParts()
        {
        
            //suka arrayEquationConvert = new List<string>();
            
            for (int i = 0; i < Equation.Length-1; i++)
            {
                if (char.IsDigit(Equation[i]) && Equation[i + 1] == 'x')
                {
                    MethodAdd(Equation[i].ToString());
                }
                if (Equation[i] =='x' && char.IsDigit(Equation[i+1]))
                {
                   
                    MethodAdd(string.Concat(Equation[i].ToString(),Equation[i+1].ToString()));          
                }
                //if (Regex.IsMatch(Equation, "sqrt("))
                //{
                //    string str = "";
                //    int index = Equation.IndexOf('s');
                //    for (int j = index; j < Equation.IndexOf(')'); j++)
                //    {
                        
                //        str += string.Concat(Equation[index]);
                //    }
                //    MethodAdd(str);
                //    str = "";
                //}
                
            }
           
        }
        public void MethodAdd(string str1)
        {
            arrayEquationConvert.Add(str1);
        }
        public List<string> GetArrayEquationConvert()
        {
            return arrayEquationConvert;
        }
       
        private void DivisionFuncion()
        {
            if (arrayEquationConvert == null) 
            {
                arrayEquationConvert = new List<string>();
            }
            
            InsertMultiplyAfterCoefficient();
        }
        private void InsertMultiplyAfterCoefficient()
        {
            
            for (int i = 0; i < Equation.Length - 1; i++)
            {
                if (char.IsDigit(Equation[i]) && Equation[i + 1] == 'x' 
                    || (Equation[i]==')' && Equation[i+1] == '('))
                {
                    Equation = Equation.Insert(i + 1, "*");
                }               
            }
            ExtractValuesFromFuncion();
        }
        private bool AviabilityBrackets()
        {
            return Equation.IndexOfAny("()".ToCharArray()) != -1 ? true : false;
        }
        private void ExtractValuesFromFuncion()
        {
            
            for (int i = 0; i < 3; i++)
            {
                if (AviabilityBrackets())
                {
                    ExtractValuesWithBracket();
                }
                else DivisionOnParts();
            }
        }
        private void ExtractValuesWithBracket()
        {
            
            int LastBracketIndex = Equation.IndexOf(')') - Equation.IndexOf('(')+1;
            MethodAdd(Equation.Substring(Equation.IndexOf('('), LastBracketIndex));
            Equation = Equation.Replace(arrayEquationConvert.Last(), "");
             
            MessageBox.Show(arrayEquationConvert.Last() + "<Last elem:" + Equation);
        }
        private void ExtractValuesWithoutBrackets()
        {
            
            //int LastSignIndex =  Equation.IndexOfAny("0123456789".ToCharArray()) - Equation.IndexOfAny("*/-+".ToCharArray());
            //Доделать
            //MethodAdd(Equation.Substring(Equation.IndexOfAny("0123456789".ToCharArray()), LastSignIndex));
            //Equation = Equation.Replace(arrayEquationConvert.Last(), "");
            //MessageBox.Show(string.Join("and ", Equation) + ":" + Equation);

        }


    }
}
