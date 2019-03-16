using System;
using System.Drawing;
using System.Windows.Forms;

namespace GraphicDraw
{
    public partial class MainForm : Form
    {
        private int BeginInterval;
        private int EndInterval;
        private string Funcion;
       

        public MainForm()
        {
            InitializeComponent();           
           
        }

        private void ButtonExit_Click(object sender, EventArgs e) => this.Close();
        private void ReadValues()
        {
             BeginInterval = (int)numeric1.Value;
             EndInterval = (int)numeric2.Value;
            Funcion =  string.Join("",textBoxFuncion.Text.ToLower().Trim(' ').Split(new char[] { },
                StringSplitOptions.RemoveEmptyEntries));
            
        }

        private void ButtonStartBuild_Click(object sender, EventArgs e)
        {
            ReadValues();

            EquationRecognition equation = new EquationRecognition(Funcion);
           
        }
            public void Error()
            {

             MessageBox.Show("Уравнение имеет неявный вид");
             textBoxFuncion.BackColor = Color.FromKnownColor(KnownColor.IndianRed);  
                
            }
        private void textBoxFuncion_MouseClick(object sender, MouseEventArgs e) 
            => (sender as TextBox).BackColor = Color.FromKnownColor(KnownColor.Window);

        
    }
}
